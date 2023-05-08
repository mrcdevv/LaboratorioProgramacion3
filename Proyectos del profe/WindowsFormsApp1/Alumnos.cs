using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.OleDb;
using System.Data;

namespace WindowsFormsApp1
{
    class Alumnos
    {
        private int dni;
        private string nombre;
        private string foto;
        public int Dni
        {
            get { return dni; }
            set { dni = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Foto
        {
            get { return foto; }
            set { foto = value; }
        }

        private OleDbConnection conector;
        private OleDbCommand comando;
        private OleDbDataAdapter adaptador;
        private DataTable tabla;

        public Alumnos()
        {
            conector = new OleDbConnection(Properties.Settings.Default.CADENA);
            comando = new OleDbCommand();

            comando.Connection = conector;
            comando.CommandType = CommandType.TableDirect;
            comando.CommandText = "Alumnos";

            adaptador = new OleDbDataAdapter(comando);
            tabla = new DataTable();
            adaptador.Fill(tabla);

            DataColumn[] dc = new DataColumn[1];
            dc[0] = tabla.Columns["dni"];
            tabla.PrimaryKey = dc;
        }

        public void buscar()
        {
            DataRow fila = tabla.Rows.Find(dni);
            if (fila == null)
            {
                nombre = "";
                foto = "";
            }
            else
            {
                nombre = fila["nombre"].ToString();
                foto = fila["foto"].ToString();
            }
        }
    }
}
