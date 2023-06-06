using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase_5
{
    public partial class frmGraficarTablero : Form
    {
        public frmGraficarTablero()
        {
            InitializeComponent();
        }

        Graphics gra;
        private void Form3_Load(object sender, EventArgs e)
        {
            gra = pictureBox1.CreateGraphics();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            int x;
            int y = 0;
            int v = 0;

            Font fuente = new Font("Verdana", 12);

            for(x = 0; x <= 600 - 60; x+=60)
            {


                for(y=0; y <= 400 - 40; y += 40)
                {
                    // Para que queden bien los numeros, el for del eje y va por afuera
                    v++;
                    gra.DrawString(v.ToString(), fuente, Brushes.Red, x, y);
                    gra.DrawRectangle(Pens.Black, x, y, 60, 40);
                }

            }


        }

    }
}
