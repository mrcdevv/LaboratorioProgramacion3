using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REPASO
{
    public partial class frmAgregarAlumno : Form
    {
        Alumnos a;
        public frmAgregarAlumno()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Barrios b = new Barrios();
            b.cargarCombo(cbBarrio);
            a = new Alumnos();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                a.Dni = Convert.ToInt32(txtDni.Text);
                a.Nombre = txtNombre.Text;
                if (rbF.Checked == true)
                {
                    a.Sexo = "F";
                }
                else
                {
                    a.Sexo = "M";
                }
                a.Foto = txtFoto.Text;
                a.Barrio = Convert.ToInt32(cbBarrio.SelectedValue);

                a.grabar();
            }
            catch(Exception ex)
            {
                MessageBox.Show("NO SE PUDO GRABAR EL REGISTRO", "ERROR");
            }
            
        }
    }
}
