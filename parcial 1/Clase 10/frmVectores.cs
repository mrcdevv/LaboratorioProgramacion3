using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmVectores : Form
    {
        public frmVectores()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string data = "UVA,POMELO,SANDIA";
            string[] frutas = data.Split(',');
            MessageBox.Show(frutas[0]);

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
