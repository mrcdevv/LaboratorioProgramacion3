using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase_2
{
    public partial class frmTabControl : Form
    {
        public frmTabControl()
        {
            InitializeComponent();
        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            MessageBox.Show("Estoy en la ficha 2");

        }
    }
}
