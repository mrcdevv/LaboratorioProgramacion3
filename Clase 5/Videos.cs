using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.OleDb;

namespace Clase_5
{
    internal class Videos
    {
            private string cadena = "";
            private OleDbCommand comando;
            private OleDbConnection conector;
            private OleDbDataAdapter adaptador;
            private DataTable tabla;

            public Videos()
            {
                cadena = Config.getCadena();
                conector = new OleDbConnection(cadena);
                comando = new OleDbCommand();
                comando.Connection = conector;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = "Videos";

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
