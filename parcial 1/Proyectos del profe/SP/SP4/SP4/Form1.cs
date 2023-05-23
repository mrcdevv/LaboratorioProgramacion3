using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Windows.Forms.DataVisualization.Charting;

namespace SP4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CLocalidad localidad = new CLocalidad();
            localidad.CargarLocalidades(cmbLocalidad);
            localidad.Dispose();
            CCultivo cultivo = new CCultivo();
            cultivo.CargarCultivos(lstCultivo);
            cultivo.Dispose();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (cmbLocalidad.Items.Count > 0 && 
                lstCultivo.Items.Count > 0 &&
                txtProduccion.Text != "")
            {
                try
                {
                    int localidad = (int)cmbLocalidad.SelectedValue;
                    int cultivo = (int)lstCultivo.SelectedValue;
                    long produccion = long.Parse(txtProduccion.Text);
                    //
                    CProduccion prod = new CProduccion();
                    prod.Actualizar(localidad, cultivo, produccion);
                    prod.Dispose();
                    MessageBox.Show("Registro actualizado", "Actualizar Producción",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void cmbLocalidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuscarProducción();
        }

        private void lstCultivo_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuscarProducción();
        }

        private void BuscarProducción()
        {
            if (cmbLocalidad.Items.Count > 0 && lstCultivo.Items.Count > 0)
            {
                try
                {
                    int localidad = (int)cmbLocalidad.SelectedValue;
                    int cultivo = (int)lstCultivo.SelectedValue;
                    CProduccion prod = new CProduccion();
                    long produccion = prod.BuscarProduccion(localidad, cultivo);
                    prod.Dispose();
                    if (produccion == 0) // no existe, el textBox queda vacío
                    {
                        txtProduccion.Text = "";
                    }
                    else // si existe, muestra el valor de producción para ese cultivo y localidad
                    {
                        txtProduccion.Text = produccion.ToString();
                    }
                }
                catch (Exception ex)
                {
                    txtProduccion.Text = "";
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnVerProduccion_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
