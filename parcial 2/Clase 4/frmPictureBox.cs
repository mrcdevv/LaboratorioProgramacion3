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
    public partial class frmPictureBox : Form
    {
        public frmPictureBox()
        {
            InitializeComponent();
        }

        Graphics gra;

        private void frmPictureBox_Load(object sender, EventArgs e)
        {
            gra = pic.CreateGraphics();
        }
        private void btnGraficar_Click(object sender, EventArgs e)
        {
            gra.DrawLine(Pens.Black, 0, 0, 399, 399);
            gra.DrawLine(Pens.Black, 399, 0, 0, 399);
            gra.DrawLine(Pens.Black, 0, 199, 399, 199);
            gra.DrawLine(Pens.Black, 199, 0, 199, 399);



        }

        private void btnGraficar2_Click(object sender, EventArgs e)
        {
            gra.DrawEllipse(Pens.Red, 0, 0, 200, 200);
            gra.DrawEllipse(Pens.Red, 200, 0, 200, 200);
            gra.DrawEllipse(Pens.Red, 0, 200, 200, 200);
            gra.DrawEllipse(Pens.Red, 200, 200, 200, 200);

        }

        private void btnGraficar3_Click(object sender, EventArgs e)
        {
            Pen myLapiz = new Pen(Color.Red, 100);
            gra.DrawLine(myLapiz, 399, 0, 0, 399);
        }

        private void btnGraficar4_Click(object sender, EventArgs e)
        {
            Pen myLapiz = new Pen(Color.Green, 10);
            gra.DrawEllipse(myLapiz, 0, 0, 399, 399);
        }

        private void btnTablero_Click(object sender, EventArgs e)
        {
            // Hacer un tablero compuesto por muchos cuadrados y cada cuadrado de colores intercalados
        }
    }
}
