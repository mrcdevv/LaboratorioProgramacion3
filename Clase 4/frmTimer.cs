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
    public partial class frmTimer : Form
    {
        public frmTimer()
        {
            InitializeComponent();
        }

        private void frmTemporizador_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Tomato;

            timer1.Interval = 1000;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTexto.Text = DateTime.Now.ToString("hh:mm:ss");
            if(lblTexto.Text == "12:00:01")
            {
                timer1.Enabled = false;
                lblTexto.Text = "Son las 12";
            }
        }
    }
}
