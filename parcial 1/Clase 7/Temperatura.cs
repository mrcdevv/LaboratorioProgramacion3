using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;


namespace Clase_7
{
    internal class Temperatura
    {

        private string conn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:CLIMA.mdb";
        private OleDbConnection connection;
        private OleDbCommand command;
        private OleDbDataAdapter adapter;
        private DataTable table;

        public Temperatura()
        {
            connection = new OleDbConnection(conn);
            command = new OleDbCommand();
            command.Connection = connection;
            command.CommandType = CommandType.TableDirect;
            command.CommandText = "Temperaturas";
            adapter = new OleDbDataAdapter(command);

            table = new DataTable();
            adapter.Fill(table);
        }

        public DataTable getTable()
        {
            return table;
        }

    }
}
