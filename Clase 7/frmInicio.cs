using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase_7
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        Temperatura temp;
        Localidad loc;

        private void frmInicio_Load(object sender, EventArgs e)
        {
            loc = new Localidad();

            try
            {
                lstLocalidad.DisplayMember = "nombre";
                lstLocalidad.ValueMember = "localidad";
                lstLocalidad.DataSource = loc.getTable();
            }
            catch (Exception err)
            {
                MessageBox.Show("Error" + err);
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            temp = new Temperatura();

            int locSeleccionada = Convert.ToInt32(lstLocalidad.SelectedValue);
            
            // Fecha
            DateTime date = dtp.Value.Date;
            string fecha = date.ToString();

            // Bandera
            bool encontrado = false;


            DataTable tablaTemp = temp.getTable();

            foreach (DataRow fila in tablaTemp.Rows)
            {
                // Fecha de la fila actual
                string fechaTabla = fila["fecha"].ToString();

                if (Convert.ToInt32(fila["localidad"]) == locSeleccionada)
                {

                    if (fechaTabla == fecha)
                    {
                        txtMaxima.Text = fila["maxima"].ToString();
                        txtMinima.Text = fila["minima"].ToString();
                        encontrado = true;
                        break;
                    }
                }
            }

            if (encontrado == false){
                MessageBox.Show("No se encontraron registos con los datos ingresados");
            }
        }
    }
}
