using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Globalization;
using System.Diagnostics;

namespace SP1
{
    public class CActualizacion
    {
        DataSet DS;
        OleDbDataAdapter DALab;
        OleDbDataAdapter DAMed;
        String TablaLab = "Laboratorios";
        String TablaMed = "Medicamentos";

        // Constructor
        public CActualizacion()
        {
            try{
                OleDbConnection cnn = new OleDbConnection();
                cnn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=Farmacia.mdb";
                cnn.Open();
                DS = new DataSet();
                // tabla Laboratorios
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = cnn;
                cmd.CommandType = CommandType.TableDirect;
                cmd.CommandText = TablaLab;
                DALab = new OleDbDataAdapter(cmd);
                DALab.Fill(DS, TablaLab);
                DataColumn[] pk = new DataColumn[1];
                pk[0] = DS.Tables[TablaLab].Columns["Laboratorio"];
                DS.Tables[TablaLab].PrimaryKey = pk;
                OleDbCommandBuilder cbLab = new OleDbCommandBuilder(DALab);
                // tabla Medicamentos
                cmd = new OleDbCommand();
                cmd.Connection = cnn;
                cmd.CommandType = CommandType.TableDirect;
                cmd.CommandText = TablaMed;
                DAMed = new OleDbDataAdapter(cmd);
                DAMed.Fill(DS, TablaMed);
                DataColumn[] pkM = new DataColumn[1];
                pkM[0] = DS.Tables[TablaMed].Columns["Codigo"];
                DS.Tables[TablaMed].PrimaryKey = pkM;
                OleDbCommandBuilder cbMed = new OleDbCommandBuilder(DAMed);
                cnn.Close();

            }
            catch (Exception ex)
            {
                String MsgErr = "CActualizacion: " + ex.Message ;
                throw new ActualizacionException(MsgErr);
            }
        }

        // procesa un archivo de medicamentos y actualiza los precios en la base de datos
        public bool Actualizar(String path, String NombreLaboratorio, int laboratorio)
        {
            bool resultado = false;
            String linea = "";
            try
            {
                // abrir el archivo de medicamentos
                StreamReader sr = new StreamReader(path);
                String encabezado = sr.ReadLine();
                String Lab = encabezado.Split('(')[0];
                if(Lab.CompareTo(NombreLaboratorio) != 0)
                {
                    throw new ActualizacionException("El archivo seleccionado no corresponde al Laboratorio " + NombreLaboratorio);
                }
                String Fecha = encabezado.Split('(')[1].Split(')')[0];
                // lee el archivo hasta el final
                while (sr.EndOfStream == false)
                {
                    linea = sr.ReadLine(); // lee línea por línea
                    //
                    String[] campos = linea.Split(','); // descompone la línea en partes
                    if(campos.Length == 3) // deben ser 3 campos
                    {
                        String codigo = campos[0];
                        String nombre = campos[1].Trim('"');
                        Single precio = Single.Parse(campos[2], CultureInfo.InvariantCulture);
                        // actualiza el precio del medicamento
                        ActualizarMedicamento(codigo, nombre, precio, laboratorio, DateTime.Parse(Fecha));
                    }
                }
                sr.Close(); // cerrar el archivo
                sr.Dispose();
                resultado = true;
            }
            catch(ActualizacionException aex)
            {   // cualquier error queda registrado con Trace
                Trace.WriteLineIf(linea != "", "Ultima lectura: " + linea);
                throw new ActualizacionException("Error actualizando archivo de Medicamentos: " + aex.Message);
            }
            return resultado;
        }

        // Actualiza el precio del medicamento y lo agrega cuando el medicamento no existe
        public void ActualizarMedicamento(String codigo, String nombre, Single precio, int laboratorio, DateTime fecha)
        {
            try
            {
                DataRow drM = DS.Tables[TablaMed].Rows.Find(codigo);
                if (drM != null)
                {
                    // contolar la fecha
                    if (fecha.CompareTo(drM["Fecha"]) >=0 )
                    {
                        // ya existe, se actualiza
                        drM.BeginEdit();
                        drM["Nombre"] = nombre;
                        drM["Precio"] = precio;
                        drM["Fecha"] = fecha;
                        drM.EndEdit();
                        DAMed.Update(DS, TablaMed);
                        Trace.WriteLine("Medicamento actualizado " + nombre);
                    }
                    else
                    {
                        Trace.WriteLine("Medicamento con fecha anterior " + nombre);
                    }
                }
                else
                {
                    // no existe, se agrega
                    DataRow drNuevo = DS.Tables[TablaMed].NewRow();
                    drNuevo["Codigo"] = long.Parse(codigo);
                    drNuevo["Nombre"] = nombre;
                    drNuevo["Precio"] = precio;
                    drNuevo["Laboratorio"] = laboratorio;
                    drNuevo["Fecha"] = fecha;
                    DS.Tables["Medicamentos"].Rows.Add(drNuevo);
                    DAMed.Update(DS, TablaMed);
                    Trace.WriteLine("Medicamento agregado " + nombre);
                }
            }
            catch(Exception ex)
            {
                String MsgErr = "CActualizacion: " + ex.Message;
                throw new ActualizacionException(MsgErr);
            }
        }

        // genera el archivo con el reporte de las actualizaciones realizadas
        public void GenerarReporte(String NombreArchivo)
        {
            //
            try
            {
                StreamWriter sw = new StreamWriter(NombreArchivo);
                sw.WriteLine("Reporte de Medicamentos Actualizados");
                sw.WriteLine("------------------------------------");
                sw.WriteLine("    Código Nombre                           Lab      Precio          Fecha");
                // recorrer la tabla de Medicamentos
                foreach (DataRow dr in DS.Tables[TablaMed].Rows)
                {
                    String linea = dr["Codigo"].ToString().PadLeft(10) + " ";
                    linea += dr["Nombre"].ToString().PadRight(30);
                    linea += dr["Laboratorio"].ToString().PadLeft(6);
                    linea += String.Format("{0,12:F2}", dr["Precio"]);
                    linea += string.Format("{0:d}", dr["Fecha"]).PadLeft(15);
                    sw.WriteLine(linea);
                }
                sw.WriteLine("");
                sw.WriteLine("Fecha del reporte: " + DateTime.Now.ToString("dd/MM/yyyy"));
                sw.Close();
                sw.Dispose();
                Trace.WriteLine("Reporte generado");
            }
            catch(Exception ex)
            {
                String MsgErr = "CActualizacion: " + ex.Message;
                throw new ActualizacionException(MsgErr);
            }
        }

        public void Dispose()
        {
            DALab.Dispose();
            DAMed.Dispose();
            DS.Dispose();
        }
    }
}
