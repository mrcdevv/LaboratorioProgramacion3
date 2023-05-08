using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace SP3
{
    public class CProvincia
    {
        DataSet DS;
        String TablaProvincia = "Provincias";
        String TablaDepartamento = "Departamentos";

        // constructor
        public CProvincia()
        {
            try
            {
                OleDbConnection cnn = new OleDbConnection();
                cnn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=Incendios.mdb";
                cnn.Open();
                DS = new DataSet();
                OleDbCommand cmdP = new OleDbCommand();
                cmdP.Connection = cnn;
                cmdP.CommandType = CommandType.TableDirect;
                cmdP.CommandText = TablaProvincia;
                OleDbDataAdapter DAP = new OleDbDataAdapter(cmdP);
                DAP.Fill(DS, TablaProvincia);
                DataColumn[] pkP = new DataColumn[1];
                pkP[0] = DS.Tables[TablaProvincia].Columns["Provincia"];
                DS.Tables[TablaProvincia].PrimaryKey = pkP;
                //
                OleDbCommand cmdD = new OleDbCommand();
                cmdD.Connection = cnn;
                cmdD.CommandType = CommandType.TableDirect;
                cmdD.CommandText = TablaDepartamento;
                OleDbDataAdapter DAD = new OleDbDataAdapter(cmdD);
                DAD.Fill(DS, TablaDepartamento);
                DataColumn[] pkD = new DataColumn[1];
                pkD[0] = DS.Tables[TablaDepartamento].Columns["Departamento"];
                DS.Tables[TablaDepartamento].PrimaryKey = pkD;
                cnn.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("CProvincia: " + ex.Message);
            }
        }

        public int ObtenerProvincia(int departamento)
        {
            // devuielve el número de provincia de un departamento
            DataRow dr = DS.Tables[TablaDepartamento].Rows.Find(departamento);
            if(dr == null)
            {
                throw new Exception("CProvincia: No existe del departamento");
            }
            return (int)dr["Provincia"];
        }

        public void CargarTreeView(TreeView tvw)
        {
            tvw.Nodes.Clear();
            // agregar la raiz
            TreeNode raiz = tvw.Nodes.Add("raiz", "INCENDIOS", 0, 0);
            try
            {


                // agregar las provincias
                foreach (DataRow drProv in DS.Tables[TablaProvincia].Rows)
                {
                    TreeNode prov = raiz.Nodes.Add(drProv["provincia"].ToString(), drProv["Nombre"].ToString(), 1, 1);
                    // agregar los departamentos de la provincia
                    foreach (DataRow drDep in DS.Tables[TablaDepartamento].Rows)
                    {
                        // comparar el numero de provincia
                        if ((int)drProv["Provincia"] == (int)drDep["Provincia"])
                        {
                            // agregar el departamento como nodo hijo de la provincia
                            prov.Nodes.Add(drDep["Departamento"].ToString(), drDep["Nombre"].ToString(), 2, 2);
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                throw new Exception("CProvincia: " + ex.Message);
            }
        }

        public void Dispose()
        {
            DS.Dispose();
        }
    }
}
