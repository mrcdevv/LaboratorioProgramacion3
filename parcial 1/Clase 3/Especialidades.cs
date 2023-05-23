using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;


namespace Clase_3
{
    internal class Especialidades
    {
        private string cadena = "";
        private OleDbCommand comando;
        private OleDbConnection conector;
        private OleDbDataAdapter adaptador;
        private DataTable tabla;

        public Especialidades() 
        {
            cadena = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\\Escritorio\\pry\\LaboratorioProgramacion3\\Clase 3\\bin\\Debug\\CLINICA.mdb";
            conector = new OleDbConnection(cadena);
            comando = new OleDbCommand();
            comando.Connection = conector;
            comando.CommandType = CommandType.TableDirect;
            comando.CommandText = "Especialidades";

            adaptador = new OleDbDataAdapter(comando);
            tabla = new DataTable();
            adaptador.Fill(tabla);
        }

        public DataTable getTabla()
        {
            return tabla;
        }

    }
}
