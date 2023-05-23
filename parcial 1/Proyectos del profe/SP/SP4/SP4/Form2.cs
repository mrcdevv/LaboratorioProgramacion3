using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SP4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // cargar las localidades en el ComboBox
            CLocalidad loc = new CLocalidad();
            loc.CargarLocalidades(cmbLocalidad);
            loc.Dispose();
            // seleccionar el primer tab
            tabGraficos.SelectedTab = tabProduccionPorLocalidad;
            // inicializar los gráficos
            chtGrafico.Titles.Add("Producción por Cultivo y Localidad");
            chtGrafico.Series.Clear();
            chtGraficoTotal.Titles.Add("Producción por Cultivo Total");
            chtGraficoTotal.Series.Clear();

        }

        private void btnGraficar_Click(object sender, EventArgs e)
        {
            CProduccion prod = new CProduccion();
            prod.GraficarPorLocalidad((int)cmbLocalidad.SelectedValue, cmbLocalidad.Text, chtGrafico);
            prod.Dispose();
        }

        private void btnGraficarTodo_Click(object sender, EventArgs e)
        {
            CProduccion prod = new CProduccion();
            prod.GraficarTotal(chtGraficoTotal);
            prod.Dispose();
        }
    }
}
