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
    public partial class frmProgressBar : Form
    {
        public frmProgressBar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();

            int cantidadFilas = tabla.Rows.Count;
            int cant = 500000;

            progressBar1.Minimum = 0;
            progressBar1.Maximum = cant;


            for(int i = 0; i < cant; i++)
            {
                progressBar1.Value = i; //No hacer esto
            }

        }
    }
}
