using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DEMO1
{
    public partial class Form1 : Form
    {
        const int ALTO = 40;
        const int ANCHO = 80;

        Graphics gra;

        Cocheras co;
        DataTable tco;

        Clientes cl;
        DataTable tcl;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gra = pictureBox1.CreateGraphics();

            co = new Cocheras();
            tco = co.getCocheras();
            cl = new Clientes();
            tcl = cl.getClientes();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Font f1 = new Font("Verdana", 8, FontStyle.Bold);

            int x = 0;
            int y = 0;
            int nc = 0;

            for (y = 0; y <= pictureBox1.Height - ALTO; y = y + ALTO)
            {
                for (x = 0; x <= pictureBox1.Width - ANCHO; x = x + ANCHO)
                {
                    nc++;

                    DataRow fco = tco.Rows.Find(nc);

                    if (fco == null)
                    {
                        gra.FillEllipse(Brushes.Green, x, y, ANCHO, ALTO);
                    }else
                    {
                       
                        gra.FillEllipse(Brushes.Red, x, y, ANCHO, ALTO);
                        DataRow fcl = tcl.Rows.Find(fco["cliente"]);

                        gra.DrawString(fcl["nombre"].ToString(), f1, Brushes.White, x + 5, y + 20);

                    }

                    gra.DrawString(nc.ToString(), f1, Brushes.White, x+15, y+4);
                }
            }
           

        }
    }
}
