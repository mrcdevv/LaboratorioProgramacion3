using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REPASO
{
    public partial class frmCantidadFrutas : Form
    {
       

        public frmCantidadFrutas()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Frutas f = new Frutas();
            LeGustan lg = new LeGustan();

            DataTable tf = f.getFrutas();
            DataTable tlg = lg.getLeGustan();

            foreach(DataRow ff in tf.Rows)
            {
                int can = 0;
                foreach(DataRow flg in tlg.Rows)
                {
                    if(ff["fruta"].ToString()==flg["fruta"].ToString())
                    {
                        can++;
                    }
                }
                gv.Rows.Add(ff["nombre"], can);
            }
        }
    }
}
