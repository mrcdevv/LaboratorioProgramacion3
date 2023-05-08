using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SP4
{
    public class CProduccion
    {
        private DataSet DS;
        private OleDbDataAdapter DAP;
        public CProduccion()
        {
            try
            {
                DS = new DataSet(); // creación del DataSet
                // conexión con la base de datos
                OleDbConnection cnn = new OleDbConnection();
                cnn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=Agricultura.mdb";
                cnn.Open();

                // tabla de Producción
                OleDbCommand cmdPro = new OleDbCommand();
                cmdPro.Connection = cnn;
                cmdPro.CommandType = CommandType.TableDirect;
                cmdPro.CommandText = "Produccion";
                // este dataAdapter está declarado como privado, acá solamente se instancia
                DAP = new OleDbDataAdapter(cmdPro);
                DAP.Fill(DS, "Produccion");
                // se agrega la clave primaria
                DataColumn[] dcP = new DataColumn[2];
                dcP[0] = DS.Tables["Produccion"].Columns["Localidad"];
                dcP[1] = DS.Tables["Produccion"].Columns["Cultivo"];
                DS.Tables["Produccion"].PrimaryKey = dcP;
                // agregar el objeto commandBulider para poder hacer cambios en la tabla
                OleDbCommandBuilder cb = new OleDbCommandBuilder(DAP);

                cnn.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("CProduccion " + ex.Message);
            }
        }

        public long BuscarProduccion(int localidad, int cultivo)
        {
            // devuelve el valor del campo producción si existe para
            // el número de localidad y cultivo pasados por parámetro
            long produccion = 0; // si no existe devuelve cero
            
            Object[] valores = new Object[2];
            valores[0] = localidad;
            valores[1] = cultivo;
            // buscar el registro en producción
            DataRow prod = DS.Tables["Produccion"].Rows.Find(valores);
            if (prod != null)
            {   // si existe obtener el valor de producción
                produccion = (int)prod["produccion"];
            }

            return produccion;
        }

        public void Actualizar(int localidad, int cultivo, long produccion)
        {
            // actualiza el valor de producción para una localidad y cultivo
            // si el registro ya existe lo actualiza, si no existe agrega 
            // un registro nuevo
            
            Object[] valores = new Object[2];
            valores[0] = localidad;
            valores[1] = cultivo;
            // buscar el registro en producción
            DataRow prod = DS.Tables["Produccion"].Rows.Find(valores);
            if(prod != null)
            {
                // ya existe el registro, se deberá editar
                prod.BeginEdit();
                prod["Produccion"] = produccion; // se actualiza
                prod.EndEdit();
            }
            else
            {
                // no existe el registro, se debe agregar uno nuevo
                DataRow nuevo = DS.Tables["Produccion"].NewRow();
                nuevo["Localidad"] = localidad;
                nuevo["Cultivo"] = cultivo;
                nuevo["Produccion"] = produccion;
                DS.Tables["Produccion"].Rows.Add(nuevo);
            }
            DAP.Update(DS, "Produccion"); // actualiza los cambios en la tabla física
        }

        public void GraficarPorLocalidad(int localidad, String Nombre, Chart cht)
        {
            // crea un gráfico para una determinada localidad
            cht.Series.Clear();
            // crear una tabla temporal
            DataTable prod = new DataTable();
            prod.Columns.Add("Produccion");
            prod.Columns.Add("Nombre");
            //
            CCultivo cultivo = new CCultivo(); // datos de los cultivos

            foreach (DataRow dr in DS.Tables["Produccion"].Rows)
            {
                // si la producción es de la localidad consultada
                if (localidad == (int)dr["Localidad"])
                {
                    String NombreCultivo = cultivo.GetCultivo((int)dr["Cultivo"]);
                    // se agrega el registro nuevo a la tabla temporal
                    DataRow nuevo = prod.NewRow();
                    nuevo["Produccion"] = (int)dr["Produccion"];
                    nuevo["Nombre"] = NombreCultivo;
                    prod.Rows.Add(nuevo);
                }
            }
            // enlazar la tabla temporal al control Chart
            cht.DataBindTable(prod.DefaultView, "Nombre");
            cht.Series[0].ChartType = SeriesChartType.Column; // tipo de gráfico
            cht.Series[0].Name = Nombre; // nombre de la serie 
            cultivo.Dispose();
        }

        public void GraficarTotal(Chart cht)
        {
            cht.Series.Clear();
            // crear una tabla temporal
            DataTable prod = new DataTable();
            prod.Columns.Add("Produccion");
            prod.Columns.Add("Nombre");
            //
            CCultivo cultivo = new CCultivo();
            DataTable cultivos = cultivo.GetCultivos();
            // recorrer todos los cultivos existentes
            foreach (DataRow cult in cultivos.Rows)
            {
                long prod_total = 0; // para cada cultivo acumula la producción
                // recorre la tabla de producción
                foreach (DataRow pro in DS.Tables["Produccion"].Rows)
                {
                    if ((int)cult["Cultivo"] == (int)pro["Cultivo"])
                    {
                        // si es el mismo cultivo, acumula
                        prod_total += (int)pro["Produccion"];
                    }
                }
                // por cada cultivo se agrega un registro nuevo a la tabla temporal 
                DataRow nuevo = prod.NewRow();
                nuevo["Produccion"] = prod_total;   // cantidad total de producción
                nuevo["Nombre"] = cult["Nombre"].ToString(); // nombre del cultivo
                prod.Rows.Add(nuevo);
            }
            // enlazar la tabla temporal al control Chart
            cht.DataBindTable(prod.DefaultView, "Nombre");
            cht.Series[0].ChartType = SeriesChartType.Column; // tipo de gráfico
            cht.Series[0].Name = "Totales"; // nombre de la serie
            cultivo.Dispose();
        }

        public void Dispose()
        {
            DS.Dispose();
        }
    }
}
