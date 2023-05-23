using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Clase_6
{
    public partial class frmReceta : Form
    {
        public frmReceta()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            sfdGuardar.ShowDialog();
            string archivo = sfdGuardar.FileName;

            if (archivo != "")
            {
                StreamWriter sw = new StreamWriter(archivo);
                sw.WriteLine(txtReceta.Text);
                sw.Close();
                sw.Dispose();
                txtReceta.Clear();
                MessageBox.Show("Archivo Guardado con exito");
            }
        }
    }
}
