using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;

namespace SP2
{
    public class CTarea
    {
        OleDbConnection CNN;
        DataSet DS;
        OleDbDataAdapter DATareas;
        OleDbDataAdapter DACarpetas;
        OleDbCommand CmdTareas;
        OleDbCommand CmdCarpetas;
        String TablaTareas = "Tareas";
        String TablaCarpetas = "Carpetas";

        // Constructor
        public CTarea()
        {
            try
            {
                CNN = new OleDbConnection();
                CNN.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=BackupProgramado.mdb";
                CNN.Open();
                DS = new DataSet();
                // Tabla de Tareas
                CmdTareas = new OleDbCommand();
                CmdTareas.Connection = CNN;
                CmdTareas.CommandType = CommandType.TableDirect;
                CmdTareas.CommandText = TablaTareas;
                DATareas = new OleDbDataAdapter(CmdTareas);
                DATareas.Fill(DS, TablaTareas);
                DataColumn[] pkT = new DataColumn[2];
                pkT[0] = DS.Tables[TablaTareas].Columns["Fecha"];
                pkT[1] = DS.Tables[TablaTareas].Columns["Hora"];
                DS.Tables[TablaTareas].PrimaryKey = pkT;
                OleDbCommandBuilder cbT = new OleDbCommandBuilder(DATareas);
                // Tabla de Carpetas
                CmdCarpetas = new OleDbCommand();
                CmdCarpetas.Connection = CNN;
                CmdCarpetas.CommandType = CommandType.TableDirect;
                CmdCarpetas.CommandText = TablaCarpetas;
                DACarpetas = new OleDbDataAdapter(CmdCarpetas);
                DACarpetas.Fill(DS, TablaCarpetas);
                DataColumn[] pkC = new DataColumn[3];
                pkC[0] = DS.Tables[TablaCarpetas].Columns["Fecha"];
                pkC[1] = DS.Tables[TablaCarpetas].Columns["Hora"];
                pkC[2] = DS.Tables[TablaCarpetas].Columns["Orden"];
                DS.Tables[TablaCarpetas].PrimaryKey = pkC;
                OleDbCommandBuilder cbC = new OleDbCommandBuilder(DACarpetas);
                CNN.Close();
            }
            catch (Exception ex)
            {
                String MsgErr = "CTarea: " + ex.Message;
                throw new Exception(MsgErr);
            }
        }

        // Devuelve la tabla de Tareas completa
        public DataTable GetTareas()
        {
            if (DS.Tables.Contains(TablaTareas))
            {
                // devuelve la tabla de Tareas completa
                return DS.Tables[TablaTareas];
            }
            else
            {
                throw new Exception("La tabla no existe");
            }
        }

        // Agrega un registro nuevo en la tabla de Tareas y
        // N registros en la tabla de Carpetas
        // Se usa una tranasacción para garantizar la intergridad de los datos
        public void AddTarea(DateTime Fecha,
                                String Hora,
                                int usuario,
                                String RutaDestino,
                                String Observacion,
                                List<String> Rutas)
        {
            OleDbTransaction Transaccion = null;
            try
            {
                // abrir la conexión
                CNN.Open();
                // iniciar la transaccion
                Transaccion = CNN.BeginTransaction();
                // agregar la tarea
                InsertTarea(Transaccion, Fecha, Hora, usuario, RutaDestino, Observacion);
                // agregar las rutas
                InsertRutas(Transaccion, Fecha, Hora, Rutas);
                // confirmar todos los cambios realizados
                Transaccion.Commit(); // finaliza la transacción
                CNN.Close();
            }
            catch(Exception ex)
            {
                // deshacer los cambios
                Transaccion.Rollback();
                throw ex;
            }
        }

        // agrega la tarea
        public void InsertTarea(OleDbTransaction transaccion, DateTime Fecha,
                                String Hora,
                                int usuario,
                                String RutaDestino,
                                String Observacion)
        {
            try
            {
                CmdTareas.Transaction = transaccion;
                DataRow dr = DS.Tables[TablaTareas].NewRow();
                dr["Fecha"] = Fecha;
                dr["Hora"] = Hora;
                dr["Usuario"] = usuario;
                dr["RutaDestino"] = RutaDestino;
                dr["Observacion"] = Observacion;
                dr["Estado"] = 0; // estado pendiente
                DS.Tables[TablaTareas].Rows.Add(dr);
                DATareas.Update(DS, TablaTareas);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // agrega la/s rutas
        public void InsertRutas(OleDbTransaction transaccion, DateTime Fecha,
                                String Hora, List<String> Rutas)
        {
            int orden = 1;
            try
            {
                CmdCarpetas.Transaction = transaccion;
                foreach (String ruta in Rutas)
                {
                    DataRow dr = DS.Tables[TablaCarpetas].NewRow();
                    dr["Fecha"] = Fecha;
                    dr["Hora"] = Hora;
                    dr["Orden"] = orden;
                    dr["RutaOrigen"] = ruta;
                    DS.Tables[TablaCarpetas].Rows.Add(dr);
                    orden++; // incrementa el número de orden
                }
                DACarpetas.Update(DS, TablaCarpetas);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // cambia el estado de una tarea pasando a Anulada
        public void AnularTarea(DateTime Fecha,
                                String Hora)
        {
            try
            {
                // formar el arreglo con los valores de la clave a buscar en Tareas
                object[] clave = new object[2];
                clave[0] = Fecha; // primer campo de la clave
                clave[1] = Hora; // segundo campo de la clave
                DataRow dr = DS.Tables[TablaTareas].Rows.Find(clave);
                if (dr != null)
                {
                    // si encuentra la tarea se controla el estado
                    if ((int)dr["Estado"] != 0) // solo se anulan tareas pendientes
                    {
                        throw new Exception("La tarea no está pendiente, no se puede anular.");
                    }
                    dr.BeginEdit();
                    dr["Estado"] = 2; // estado anulada
                    dr.EndEdit();
                    DATareas.Update(DS, TablaTareas);
                }
                else
                {
                    // si no encuentra la tarea se dispara una excepción
                    throw new Exception("La tarea no existe");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // Ejecución de las tareas programadas
        public void EjecutarTarea(Timer timer)
        {
            timer.Enabled = false;
            try
            {
                // se obtiene la fecha y hora actuales
                DateTime Fecha = DateTime.Now.Date;
                String Hora = DateTime.Now.ToShortTimeString().Substring(0, 5);
                Object[] clave = new Object[2];
                clave[0] = Fecha;
                clave[1] = Hora;
                // buscar tareas con esa misma fecha y hora
                DataRow dr = DS.Tables[TablaTareas].Rows.Find(clave);
                // controlar que exista la tarea y que su estado sea Pendiente: 0
                if (dr != null && (int)dr["Estado"] == 0) 
                {
                    int orden = 1;
                    bool existeRuta = true;
                    // buscar todas las carpetas a copiar de la tarea
                    while (existeRuta)
                    {
                        Object[] claveRuta = new Object[3];
                        claveRuta[0] = Fecha;
                        claveRuta[1] = Hora;
                        claveRuta[2] = orden;
                        DataRow drR = DS.Tables[TablaCarpetas].Rows.Find(claveRuta);
                        if (drR != null)
                        {
                            // realizar las copias de los archivos
                            DirectoryInfo diSource = new DirectoryInfo(drR["RutaOrigen"].ToString());
                            DirectoryInfo diTarget = new DirectoryInfo(dr["RutaDestino"].ToString());

                            CopyAll(diSource, diTarget); // copia el contenido de la carpeta
                            orden++;
                        }
                        else
                        {
                            existeRuta = false; // no hay más rutas para copiar
                        }
                    }
                    // actualizar el estado de la tarea
                    dr.BeginEdit();
                    dr["Estado"] = 1; // estado terminada
                    dr.EndEdit();
                    DATareas.Update(DS, TablaTareas);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            timer.Enabled = true;
        }

        // copiar los archivos de una carpeta a otra
        public void CopyAll(DirectoryInfo source, DirectoryInfo target)
        {
            String Ruta = Path.Combine(target.FullName, source.Name);
            Directory.CreateDirectory(Ruta); // si existe crea el directorio destino

            // copiar los archivos del directorio origen al directorio destino.
            foreach (FileInfo fi in source.GetFiles())
            {
                fi.CopyTo(Path.Combine(Ruta, fi.Name), true);
            }
        }

        public void Dispose()
        {
            DS.Dispose();
        }
    }
}
