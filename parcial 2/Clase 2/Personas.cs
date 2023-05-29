using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;

namespace Clase_2
{
    internal class Personas 
    { 
        private OleDbConnection conector;
        private OleDbCommand comando;
        private OleDbDataAdapter adaptador;
        private DataTable tabla;
        private string sql;

        public Personas()
        {
            conector = new OleDbConnection(Properties.Settings.Default.CADENA);
            comando = new OleDbCommand();

            comando.Connection = conector;
            comando.CommandType = CommandType.Text;

            adaptador = new OleDbDataAdapter(comando);
            tabla = new DataTable();
            
        }

        public void Listar(string color, DataGridView dgv)
        {
            sql = "SELECT * FROM Personas WHERE ojos='" + color + "'";
            comando.CommandText = sql;

            adaptador.Fill(tabla);
            dgv.DataSource = tabla;

        }

    }
    
}
