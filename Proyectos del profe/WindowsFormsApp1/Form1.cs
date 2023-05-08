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
    public partial class Form1 : Form
    {
        Barrios b;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                b.Barrio = Convert.ToInt32(txtBarrio.Text);
                b.Nombre = txtNombre.Text;
                b.grabar();
                txtBarrio.Text = "";
                txtNombre.Text = "";
                txtBarrio.Focus();
            }
            catch(Exception ex)
            {
                MessageBox.Show("NO SE PUDO GRABAR EL REGISTRO", "ERROR");
            }
          

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            b.Barrio = Convert.ToInt32(txtBarrio.Text);
            b.buscar();
            if(b.Nombre=="")
            {
                MessageBox.Show("NO EXISTE EL BARRIO", "ERROR");
            }
            txtNombre.Text = b.Nombre;


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            b = new Barrios();
        }
    }
}
