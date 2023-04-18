using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase_6
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            cdColores.ShowDialog();
            this.BackColor = cdColores.Color;
        }

        private void btnFuente_Click(object sender, EventArgs e)
        {
            fdTexto.ShowDialog();
            lbl1.Font = fdTexto.Font;
        }

        private void btnAbrirArchivo_Click(object sender, EventArgs e)
        {
            ofdAbrirArchivo.Filter = "Archivos de texto | *.txt | Archivos pdf | *.pdf" ; //Que archivos se podran seleccionar
            ofdAbrirArchivo.ShowDialog();
            

            if (ofdAbrirArchivo.FileName == "openFileDialog1")
            {
                lbl2.Text = "";
            }
            else
            {
                lbl2.Text = ofdAbrirArchivo.FileName;
            }

        }

        private void btnBuscarArchivo_Click(object sender, EventArgs e)
        {
            fdbBuscarArchivo.ShowDialog();
            lbl3.Text = fdbBuscarArchivo.SelectedPath;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            sfdGuardarArchivo.ShowDialog();
            lbl4.Text = sfdGuardarArchivo.FileName;
        }
    }
}
