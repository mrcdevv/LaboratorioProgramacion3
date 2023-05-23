using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.OleDb;
using System.Data;

namespace WindowsFormsApp1
{
    class Barrios
    {
        private int barrio;
        private string nombre;

        public int Barrio   
        {
            get { return barrio; }   
            set { barrio = value; }  
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private OleDbConnection conector;
        private OleDbCommand comando;
        private OleDbDataAdapter adaptador;
        private DataTable tabla;

        public Barrios()
        {
            conector = new OleDbConnection(Properties.Settings.Default.CADENA);
            comando = new OleDbCommand();

            comando.Connection = conector;
            comando.CommandType = CommandType.TableDirect;
            comando.CommandText = "Barrios";

            adaptador = new OleDbDataAdapter(comando);
            tabla = new DataTable();
            adaptador.Fill(tabla);

            DataColumn[] dc = new DataColumn[1];
            dc[0] = tabla.Columns["barrio"];
            tabla.PrimaryKey = dc;

        }

        public void grabar()
        {
            DataRow fila = tabla.NewRow();
            fila["barrio"] = barrio;
            fila["nombre"] = nombre;
            tabla.Rows.Add(fila);

            OleDbCommandBuilder cb = new OleDbCommandBuilder(adaptador);
            adaptador.Update(tabla);

        }

        public void buscar()
        {
            DataRow fila = tabla.Rows.Find(barrio);
            if(fila==null)
            {
                nombre = "";
            }else
            {
                nombre = fila["nombre"].ToString();
            }
        }
    }
}
