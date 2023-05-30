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
    public partial class frmEjercicio : Form
    {
        public frmEjercicio()
        {
            InitializeComponent();
        }

        Localidad loc;
        Cultivo cul;
        Produccion prod;


        private void frmEjercicio_Load(object sender, EventArgs e)
        {
            loc = new Localidad();
            cul = new Cultivo();
            prod = new Produccion();


            loc.Listar(cboLocalidad);
            loc.Listar(lstbox);
            cul.Listar(cboCultivo);


        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            int numLoc = Convert.ToInt32(cboLocalidad.SelectedValue);
            int numCul = Convert.ToInt32(cboCultivo.SelectedValue);
            int toneladas = Convert.ToInt32(txtToneladas.Text);

            prod.Actualizar(numLoc, numCul, toneladas);

        }

        private void btnGraficar_Click(object sender, EventArgs e)
        {
            int numLoc = Convert.ToInt32(lstbox.SelectedValue);

            prod.Graficar(numLoc, chart1);

        }
    }
}
