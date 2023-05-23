using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace Clase_1
{
    public partial class frmChart2 : Form
    {
        public frmChart2()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            chart.Series.Clear();
            Series serie = chart.Series.Add("PRIMER PARCIAL");

            Random r = new Random();

            int menores = 0;
            int mayores = 0;

            for(int bolas = 0; bolas < 50; bolas++)
            {
                int v = r.Next(0, 36);
                serie.Points.Add(v);

                if (v > 18)
                {
                    mayores++;
                }
                else
                {
                    menores++;
                }
            }

            label1.Text = "Mayores:" + mayores;
            label2.Text = "Menores:" + menores;

        }
    }
}
