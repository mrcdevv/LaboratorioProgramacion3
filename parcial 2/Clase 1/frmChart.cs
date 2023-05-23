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
    public partial class frmChart : Form
    {
        public frmChart()
        {
            InitializeComponent();
        }

        string[] alumnos = { "malu1", "malu2", "malu3", "malu4" };
        int[] notas = { 1, 5, 11, 3 };
        int[] notas2 = { 4, 3, 10, 7 };



        private void btnClear_Click(object sender, EventArgs e)
        {
            chart.Series.Clear();
        }

        private void btnAddSerie_Click(object sender, EventArgs e)
        {
            Series malu = chart.Series.Add("Primer parcial");

            //malu.Points.Add(50);
            //malu.Points.Add(75);

            // Otra Variacion
            //chart.Series[0].Points.Add(50);
            //chart.Series[0].Points.Add(75);

            malu.Points.AddXY("Ana", 97);
            malu.Points.AddXY("Joao", 62);
            malu.Points.AddXY("Robinho", 80);
        }

        private void btnAdd2_Click(object sender, EventArgs e)
        {
            chart.Series.Clear();
            Series parcial1 = chart.Series.Add("PRIMER PARCIAL");
            Series parcial2 = chart.Series.Add("SEGUNDO PARCIAL");

            // Cambiar el tipo de grafico
            //parcial.ChartType = SeriesChartType.SplineArea;

            int i = 0;

            while (i < alumnos.Length)
            {
                parcial1.Points.AddXY(alumnos[i], notas[i]);
                parcial2.Points.AddXY(alumnos[i], notas2[i]);
                i++;
            }

            chart.Titles.Clear();
            chart.Titles.Add("LABORATORIO DE PROGRAMACION");

            chart.ChartAreas[0].AxisX.Title = "Alumnos";
            chart.ChartAreas[0].AxisX.Title = "Notas";

            

        }
    }
}
