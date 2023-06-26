using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO1
{
    using System.Data.OleDb;
    using System.Data;
    class Clientes
    {
        private OleDbConnection conector;
        private OleDbCommand comando;
        private OleDbDataAdapter adaptador;
        private DataTable tabla;

        public Clientes()
        {
            conector = new OleDbConnection(Properties.Settings.Default.CADENA);
            comando = new OleDbCommand();

            comando.Connection = conector;
            comando.CommandType = CommandType.TableDirect;
            comando.CommandText = "Clientes";

            adaptador = new OleDbDataAdapter(comando);
            tabla = new DataTable();
            adaptador.Fill(tabla);

            DataColumn[] dc = new DataColumn[1];
            dc[0] = tabla.Columns["cliente"];
            tabla.PrimaryKey = dc;
        }

        public DataTable getClientes()
        {
            return tabla;
        }
    }
}
