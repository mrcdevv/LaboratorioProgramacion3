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
    public partial class frmJuego : Form
    {
        public frmJuego()
        {
            InitializeComponent();
        }
        Graphics gra;
        private void Form2_Load(object sender, EventArgs e)
        {
            pic.Image = Properties.Resources.Arturo_Moya;
            label1.Top = this.Height - (2 * label1.Height);
            gra = this.CreateGraphics();
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode.ToString())
            {
                case "Left":
                    Izquierda();
                    break;
                case "Right":
                    Derecha();
                    break;
                case "Space":
                    Laser();
                    break;
            }
        }

        private void Izquierda()
        {
            label1.Left -= 5;
        }
        private void Derecha()
        {
            label1.Left += 5;
        }
        private void Laser()
        {
            float x1 = label1.Left + (label1.Width / 2) - 3;
            float y1 = label1.Top;

            while (y1 > 0)
            {
                gra.FillEllipse(Brushes.Red, x1, y1, 6, 6);
                y1 -= (float)0.2;
            }
            y1 = label1.Top;

            while (y1 > 0)
            {
                gra.FillEllipse(Brushes.Black, x1, y1, 6, 6);
                y1 -= (float)0.2;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random r = new Random();
            int pos = r.Next(0, this.Width - pic.Width);
            pic.Left = pos;
        }
    }
}
