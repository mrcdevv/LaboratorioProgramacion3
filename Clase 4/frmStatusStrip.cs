using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase_4
{
    public partial class frmStatusStrip : Form
    {
        public frmStatusStrip()
        {
            InitializeComponent();
        }

        private void frmStatusStrip_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Enabled = true;
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            ss.Items.Add("Hola mundo");

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ss.Items.Clear();
            ss.Items.Add("Hora actual --->");
            ss.Items.Add(DateTime.Now.ToString());
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ss.Items.Clear();
        }
    }
}
