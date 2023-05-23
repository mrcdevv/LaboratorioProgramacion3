using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace SP2
{
    public class CUsuario
    {
        DataSet DS;
        String Tabla = "Usuarios";

        // Constructor
        public CUsuario()
        {
            try
            {
                OleDbConnection cnn = new OleDbConnection();
                cnn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=BackupProgramado.mdb";
                cnn.Open();
                DS = new DataSet();
                // tabla de Usuarios
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = cnn;
                cmd.CommandType = CommandType.TableDirect;
                cmd.CommandText = Tabla;
                OleDbDataAdapter DA = new OleDbDataAdapter(cmd);
                DA.Fill(DS, Tabla);
                DataColumn[] pk = new DataColumn[1];
                pk[0] = DS.Tables[Tabla].Columns["usuario"];
                DS.Tables[Tabla].PrimaryKey = pk;
                OleDbCommandBuilder cb = new OleDbCommandBuilder(DA);
                cnn.Close();
            }
            catch (Exception ex)
            {
                String MsgErr = "CUsuario: " + ex.Message;
                throw new Exception(MsgErr);
            }
        }

        // devuelve la tabla de Usuarios completa
        public DataTable GetUsuarios()
        {
            if (DS.Tables.Count == 1)
            {
                return DS.Tables[Tabla];
            }
            else
            {
                throw new Exception("La tabla no existe");
            }
        }

        // devuelve el nombre del usuario pasado por parámetro
        public String GetUsuario(int usuario)
        {
            String nombre = "";
            DataRow drU = DS.Tables[Tabla].Rows.Find(usuario);
            if(drU != null)
            {
                nombre = drU["Nombre"].ToString();
            }
            else
            {
                throw new Exception("El usuario no existe");
            }
            return nombre;
        }

        // devuelve el pasword del usuario pasado por parámetro
        public String GetPasswordUsuario(int usuario)
        {
            DataRow drU = DS.Tables[Tabla].Rows.Find(usuario);
            if(drU != null)
            {
                return drU["palabra"].ToString();
            }
            else
            {
                throw new Exception("El usuario no existe");
            }
        }

        public void Dispose()
        {
            DS.Dispose();
        }
    }
}
