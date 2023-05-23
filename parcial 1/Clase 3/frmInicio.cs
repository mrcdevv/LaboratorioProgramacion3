using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase_3
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        Especialidades esp;
        Medicos med;
        DataTable tabla;

        private void frmInicio_Load(object sender, EventArgs e)
        {
            dgvMedicos.Columns.Add("colMatricula", "Matricula");
            dgvMedicos.Columns.Add("colNombre", "Nombre");
            dgvMedicos.Columns.Add("colCelular", "Celular");

            try
            {
                esp = new Especialidades();
                lstEspecialidad.DisplayMember = "nombre";
                lstEspecialidad.ValueMember = "especialidad";
                lstEspecialidad.DataSource = esp.getTabla();

                med = new Medicos();
                tabla = med.getTabla();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un problema: " + ex);
                this.Close();
            }
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            dgvMedicos.Rows.Clear();

            int especialidad = Convert.ToInt32(lstEspecialidad.SelectedValue);

            foreach (DataRow fila in tabla.Rows)
            {
                if (Convert.ToInt32(fila["especialidad"]) == especialidad)
                {
                    dgvMedicos.Rows.Add(fila["matricula"], fila["nombre"], fila["celular"]);
                }
            }
        }

        private void btnForm2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }
    }
}
