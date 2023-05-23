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
    public class CIncendio
    {
        DataSet DS;
        String TablaIncendio = "Incendios";
        String TablaTipoIncendio = "TipoIncendio";

        // constructor
        public CIncendio()
        {
            try
            {
                OleDbConnection cnn = new OleDbConnection();
                cnn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=Incendios.mdb";
                cnn.Open();
                DS = new DataSet();
                OleDbCommand cmdI = new OleDbCommand();
                cmdI.Connection = cnn;
                cmdI.CommandType = CommandType.TableDirect;
                cmdI.CommandText = TablaIncendio;
                OleDbDataAdapter DAI = new OleDbDataAdapter(cmdI);
                DAI.Fill(DS, TablaIncendio);
                DataColumn[] pkI = new DataColumn[2];
                pkI[0] = DS.Tables[TablaIncendio].Columns["Departamento"];
                pkI[1] = DS.Tables[TablaIncendio].Columns["TipoIncendio"];
                DS.Tables[TablaIncendio].PrimaryKey = pkI;
                //
                OleDbCommand cmdTI = new OleDbCommand();
                cmdTI.Connection = cnn;
                cmdTI.CommandType = CommandType.TableDirect;
                cmdTI.CommandText = TablaTipoIncendio;
                OleDbDataAdapter DATI = new OleDbDataAdapter(cmdTI);
                DATI.Fill(DS, TablaTipoIncendio);
                DataColumn[] pkTI = new DataColumn[1];
                pkTI[0] = DS.Tables[TablaTipoIncendio].Columns["TipoIncendio"];
                DS.Tables[TablaTipoIncendio].PrimaryKey = pkTI;
                cnn.Close();
            }
            catch (Exception ex)
            {
                String MsgErr = "CIncendio: " + ex.Message;
                throw new Exception(MsgErr);
            }
        }

        public int ObtenerIncendiosPorDepartamento(int departamento, ListView lvw)
        {
            int Total = 0; // cantidad total de incendios del departamento
            int Cantidad = 0; // cantidad de incendios por tipo

            lvw.Items.Clear();
            // recorrer los tipos de Incendio
            foreach (DataRow dr in DS.Tables[TablaTipoIncendio].Rows)
            {
                Cantidad = 0;
                // texto del item (primera columna de LsitView)
                ListViewItem item = lvw.Items.Add(dr["Descripcion"].ToString());
                // recorrer la tabla de incendios
                foreach(DataRow drI in DS.Tables[TablaIncendio].Rows)
                {
                    if( departamento == (int)drI["Departamento"] &&
                        (int)dr["TipoIncendio"] == (int)drI["TipoIncendio"])
                    {
                        Cantidad += (int)drI["Cantidad"];
                    }
                }
                
                // texto del subitem (segunda columna)
                item.SubItems.Add(Cantidad.ToString());
                // acumular el total
                Total += Cantidad;
            }

            return Total;
        }


        public int ObtenerIncendiosPorProvincia(int provincia, ListView lvw)
        {
            int Total = 0; // cantidad total de incendios de la provincia
            int Cantidad = 0; // cantidad de incendios por tipo
            int prov_dep;
            CProvincia prov = new CProvincia();

            lvw.Items.Clear();
            // recorrer los tipos de Incendio
            foreach (DataRow dr in DS.Tables[TablaTipoIncendio].Rows)
            {
                Cantidad = 0;
                // texto del item (primera columna de LsitView)
                ListViewItem item = lvw.Items.Add(dr["Descripcion"].ToString());
                // recorrer la tabla de incendios
                foreach (DataRow drI in DS.Tables[TablaIncendio].Rows)
                {
                    prov_dep = prov.ObtenerProvincia((int)drI["Departamento"]);

                    if (provincia == prov_dep &&
                        (int)dr["TipoIncendio"] == (int)drI["TipoIncendio"])
                    {
                        Cantidad += (int)drI["Cantidad"];
                    }
                }

                // texto del subitem (segunda columna)
                item.SubItems.Add(Cantidad.ToString());
                // acumular el total
                Total += Cantidad;
            }
            prov.Dispose();
         
            return Total;
        }

        public int ObtenerIncendios(ListView lvw)
        {
            int Total = 0; // cantidad total de incendios 
            int Cantidad = 0; // cantidad de incendios por tipo
 
            lvw.Items.Clear();
            // recorrer los tipos de Incendio
            foreach (DataRow dr in DS.Tables[TablaTipoIncendio].Rows)
            {
                Cantidad = 0;
                // texto del item (primera columna de LsitView)
                ListViewItem item = lvw.Items.Add(dr["Descripcion"].ToString());
                // recorrer la tabla de incendios
                foreach (DataRow drI in DS.Tables[TablaIncendio].Rows)
                {
                    if ((int)dr["TipoIncendio"] == (int)drI["TipoIncendio"])
                    {
                        Cantidad += (int)drI["Cantidad"];
                    }
                }

                // texto del subitem (segunda columna)
                item.SubItems.Add(Cantidad.ToString());
                // acumular el total
                Total += Cantidad;
            }

            return Total;
        }

        public void Dispose()
        {
            DS.Dispose();
        }
    }
}
