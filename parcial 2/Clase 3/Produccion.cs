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
            object[] vec = new object[2];
            vec[0] = localidad;
            vec[1] = cultivo;

            DataRow fila = tabla.Rows.Find(vec);
            

            fila["toneladas"] = toneladas;

            OleDbCommandBuilder cb = new OleDbCommandBuilder();
            adaptador.Update(tabla);


            //Agregar un registro nuevo. Antes de agregar tengo que validar que el codigo no exista
            //usando lo de arriba (find)

            //DataRow fila1 = tabla.NewRow(); 
            //fila1["localidad"] = localidad;
            //fila1["cultivo"] = cultivo;
            //fila1["toneladads"] = toneladas;

            //tabla.Rows.Add(fila1);
            //OleDbCommandBuilder cb = new OleDbCommandBuilder();
            //adaptador.Update(tabla);
        }

        public void Graficar(int localidad, Chart grafico)
        {

        }


    }
}
