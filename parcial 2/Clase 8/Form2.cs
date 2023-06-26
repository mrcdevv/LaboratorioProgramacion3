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

namespace ELECCIONES
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = @"
                SELECT L.gobernador, SUM(V.votos) AS votos
                FROM Listas L
                INNER JOIN Votos V ON L.lista=V.lista
                GROUP BY L.gobernador
                ORDER BY SUM(V.votos) DESC
            ";

            Datos d = new Datos();
            DataTable tabla = d.getData(sql);

            Series serie = new Series();
            serie = chart1.Series.Add("Resultados");

            foreach(DataRow fila in tabla.Rows)
            {
                serie.Points.AddXY(fila["gobernador"], fila["votos"]);
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
