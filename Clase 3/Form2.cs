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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        Medicos med;

        private void btnCargar_Click(object sender, EventArgs e)
        {
            med = new Medicos();
            lstLista.DisplayMember = "nombre";
            lstLista.ValueMember = "matricula";
            lstLista.DataSource = med.getTabla();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(lstLista.SelectedValue.ToString());
            MessageBox.Show(lstLista.Text);
        }
    }
}
