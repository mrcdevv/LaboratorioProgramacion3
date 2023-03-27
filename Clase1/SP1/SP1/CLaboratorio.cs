using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.IO;

namespace SP1
{
    public class CLaboratorio
    {
        DataSet DS;
        String Tabla = "Laboratorios";

        // Cconstructor
        public CLaboratorio()
        {
            try
            {
                OleDbConnection cnn = new OleDbConnection();
                cnn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=Farmacia.mdb";
                cnn.Open();
                DS = new DataSet();
                // tabla de Laboratorios
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = cnn;
                cmd.CommandType = CommandType.TableDirect;
                cmd.CommandText = Tabla;
                OleDbDataAdapter DA = new OleDbDataAdapter(cmd);
                DA.Fill(DS, Tabla);
                DataColumn[] pk = new DataColumn[1];
                pk[0] = DS.Tables[Tabla].Columns["Laboratorio"];
                DS.Tables[Tabla].PrimaryKey = pk;
                OleDbCommandBuilder cb = new OleDbCommandBuilder(DA);
                cnn.Close();
            }
            catch(Exception ex)
            {
                String MsgErr = "CLaboratorio: " + ex.Message;
                throw new LaboratorioException(MsgErr);
            }
        }

        // devuelve la tabla completa
        public DataTable GetLaboratorios()
        {
            if(DS != null && DS.Tables.Count == 1)
            {
                return DS.Tables["Laboratorios"];
            }
            return null;
        }

        public void Dispose()
        {
            DS.Dispose();
        }
    }
}
