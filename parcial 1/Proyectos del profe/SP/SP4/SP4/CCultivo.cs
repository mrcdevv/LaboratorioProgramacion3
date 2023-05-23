using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace SP4
{
    public class CCultivo
    {
        private DataSet DS;

        public CCultivo()
        {
            try
            {
                DS = new DataSet(); // creación del DataSet
                // conexión con la base de datos
                OleDbConnection cnn = new OleDbConnection();
                cnn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=Agricultura.mdb";
                cnn.Open();

                // Proceso de la tabla Localidades
                OleDbCommand cmdC = new OleDbCommand();
                cmdC.Connection = cnn;
                cmdC.CommandType = CommandType.TableDirect;
                cmdC.CommandText = "Cultivos";

                OleDbDataAdapter daC = new OleDbDataAdapter(cmdC);
                daC.Fill(DS, "Cultivos");
                // se agrega la clave primaria
                DataColumn[] dcC = new DataColumn[1];
                dcC[0] = DS.Tables["Cultivos"].Columns["Cultivo"];
                DS.Tables["Cultivos"].PrimaryKey = dcC;

                cnn.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("CCultivo " + ex.Message);
            }
        }

        public void CargarCultivos(ListBox lst)
        {
            // rellena un ListBox con los nombres de los cultivos
            lst.Items.Clear();
            lst.DisplayMember = "Nombre";
            lst.ValueMember = "Cultivo";
            lst.DataSource = DS.Tables["Cultivos"];
        }

        public DataTable GetCultivos()
        {
            // devuelve la tabla completa de Cultivos
            return DS.Tables["Cultivos"];
        }

        public String GetCultivo(int cultivo)
        {
            // devuelve el nombre de un cultivo, si su número existe
            String Nombre = ""; // si no existe, develve vacío
            DataRow dr = DS.Tables["Cultivos"].Rows.Find(cultivo);
            if(dr != null)
            {
                Nombre = dr["Nombre"].ToString();
            }
            return Nombre;
        }

        public void Dispose()
        {
            DS.Dispose();
        }
    }
}
