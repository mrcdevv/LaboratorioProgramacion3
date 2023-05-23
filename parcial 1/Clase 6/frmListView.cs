using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase_6
{
    public partial class frmListView : Form
    {
        public frmListView()
        {
            InitializeComponent();
        }

        private void frmListView_Load(object sender, EventArgs e)
        {
            string[] comidas =
            {
                "Comida 1",
                "Comida 2",
                "Comida 3",
                "Comida 4",
                "Comida 5",
                "Comida 1",
                "Comida 2",
                "Comida 3",
                "Comida 4",
                "Comida 5",
                "Comida 1",
                "Comida 2",
                "Comida 3",
                "Comida 4",
                "Comida 5",
            };

            foreach (string comida in comidas)
            {
                ListViewItem lvi = lv1.Items.Add(comida);
                lv1.Tag = comida;

            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = lv.Items.Add("43449854");
            lvi.SubItems.Add("Marco");
            lvi.SubItems.Add("Sofia");
        }

        private void btnLista_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in lv1.Items)
            {
                if (lvi.Checked == true)
                {
                    MessageBox.Show(lvi.Text);
                }
            }
        }


    }
}
