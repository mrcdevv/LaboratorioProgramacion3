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
    public partial class frmPrintDocument : Form
    {
        Gente g;
        DataTable tabla;
        int pos;

        public frmPrintDocument()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PPD.ShowDialog();
        }

        private void PD_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            pos = 0;
        }

        private void PD_EndPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }

        private void PD_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font f1 = new Font("Verdana", 12);
            Font f2 = new Font("Verdana", 12, FontStyle.Italic);
            Font titulo = new Font("Comic Sans MS", 25, FontStyle.Bold);
            int x = e.MarginBounds.Left;
            int y = e.MarginBounds.Top;

            e.Graphics.DrawString("LISTA EMPLEADOS", titulo, Brushes.Black, x, y);
            y = y + titulo.Height * 2;

            e.Graphics.DrawString("Nombre Cliente", f2, Brushes.Black, x, y);
            e.Graphics.DrawString("Correo electronico", f2, Brushes.Black, x + 300, y);
            y = y + f2.Height * 2 ;


            while (pos < tabla.Rows.Count)
            {
                
                e.Graphics.DrawString(tabla.Rows[pos]["full_name"].ToString(), f1, Brushes.Black, x, y);
                e.Graphics.DrawString(tabla.Rows[pos]["email"].ToString(), f1, Brushes.Black, x+300, y);

                y = y + f1.Height;

                if(y > e.MarginBounds.Bottom)
                {
                    break;
                }

                pos++;
            }

            if (pos < tabla.Rows.Count)
            {
                e.HasMorePages = true;
            }
            else
            {
                e.HasMorePages = false;
            }



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            g = new Gente();
            tabla = g.GetTabla();
        }
    }
}
