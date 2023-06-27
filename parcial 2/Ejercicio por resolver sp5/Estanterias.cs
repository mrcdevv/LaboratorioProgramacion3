using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sp5_cerrajeria
{
    internal class Estanterias
    {
        private OleDbConnection conector;
        private OleDbCommand comando;
        private OleDbDataAdapter adaptador;
        private DataTable tabla;

        public Estanterias()
        {
            conector = new OleDbConnection(Properties.Settings.Default.CADENA);
            comando = new OleDbCommand();

            comando.Connection = conector;
            comando.CommandType = CommandType.TableDirect;
            comando.CommandText = "Estanterias";

            adaptador = new OleDbDataAdapter(comando);
            tabla = new DataTable();
            adaptador.Fill(tabla);

            DataColumn[] dc = new DataColumn[1];
            dc[0] = tabla.Columns["NumeroEstanteria"];
            tabla.PrimaryKey = dc;
        }

        public DataTable Get_Tabla()
        {
            return tabla;
        }

        public DataRow Get_Value(int valor)
        {
            return tabla.Rows.Find(valor);
        }
    }
}
