using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace Clase_3
{
    internal class Produccion
    {
        private OleDbConnection conector;
        private OleDbCommand comando;
        private OleDbDataAdapter adaptador;
        private DataTable tabla;


        public Produccion()
        {
            conector = new OleDbConnection(Properties.Settings.Default.CADENA);
            comando = new OleDbCommand();

            comando.Connection = conector;
            comando.CommandType = CommandType.TableDirect;
            comando.CommandText = "Produccion";

            adaptador = new OleDbDataAdapter(comando);
            tabla = new DataTable();
            adaptador.Fill(tabla);

            DataColumn[] dc = new DataColumn[2];
            dc[0] = tabla.Columns["localidad"];
            dc[1] = tabla.Columns["cultivo"];
            tabla.PrimaryKey = dc;
        }

        public void Actualizar(int localidad, int cultivo, int toneladas)
        {
            // Si ya existe una fila con el registro
            object[] vec = new object[2];
            vec[0] = localidad;
            vec[1] = cultivo;

            DataRow fila = tabla.Rows.Find(vec);
            if (fila != null)
            {
                fila["toneladas"] = toneladas;
            } 
            else
            {
                fila = tabla.NewRow();
                fila["localidad"] = localidad;
                fila["cultivo"] = cultivo;
                fila["toneladas"] = toneladas;
                tabla.Rows.Add(fila);
            }


            OleDbCommandBuilder cb = new OleDbCommandBuilder(adaptador);
            adaptador.Update(tabla);
            cb.Dispose();
        }



        public void Graficar(int localidad, Chart grafico)
        {

        }


    }
}
