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
    public class CLocalidad
    {
        private DataSet DS;

        public CLocalidad()
        {
            try
            {
                DS = new DataSet(); // creación del DataSet
                // conexión con la base de datos
                OleDbConnection cnn = new OleDbConnection();
                cnn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=Agricultura.mdb";
                cnn.Open();

                // Proceso de la tabla Localidades
                OleDbCommand cmdLoc = new OleDbCommand();
                cmdLoc.Connection = cnn;
                cmdLoc.CommandType = CommandType.TableDirect;
                cmdLoc.CommandText = "Localidades";

                OleDbDataAdapter daLoc = new OleDbDataAdapter(cmdLoc);
                daLoc.Fill(DS, "Localidades");
                // se agrega la clave primaria
                DataColumn[] dcL = new DataColumn[1];
                dcL[0] = DS.Tables["Localidades"].Columns["Localidad"];
                DS.Tables["Localidades"].PrimaryKey = dcL;

                cnn.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("CLocalidad " + ex.Message);
            }
        }

        public void CargarLocalidades(ComboBox cmb)
        {
            // rellena un ComboBox con los nombres de las localidades
            cmb.Items.Clear();
            cmb.DisplayMember = "Nombre";
            cmb.ValueMember = "Localidad";
            cmb.DataSource = DS.Tables["Localidades"];
        }

        public void Dispose()
        {
            DS.Dispose();
        }
    }
}
