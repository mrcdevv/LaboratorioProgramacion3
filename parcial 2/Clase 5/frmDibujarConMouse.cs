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
    public partial class frmDibujarConMouse : Form
    {
        public frmDibujarConMouse()
        {
            InitializeComponent();
        }

        Graphics gra;

        private void Form1_Load(object sender, EventArgs e)
        {
            gra = this.CreateGraphics();

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            gra.FillEllipse(Brushes.Teal, e.X, e.Y, 20, 20);
        }
    }
}
