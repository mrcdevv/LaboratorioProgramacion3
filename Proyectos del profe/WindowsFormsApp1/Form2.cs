using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {

        Alumnos a;
        public Form2()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
          
            a.Dni = Convert.ToInt32(txtDni.Text);
            a.buscar();
            txtNombre.Text = a.Nombre;
            if(a.Nombre == "")
            {
                pbFoto.Image = null;
            
            }else
            {
                pbFoto.Load("JPG/" + a.Foto);
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            a = new Alumnos();
        }
    }
}
