using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase_4
{
    public partial class frmTreeView : Form
    {
        public frmTreeView()
        {
            InitializeComponent();
        }

        private void frmArboles_Load(object sender, EventArgs e)
        {
            TreeNode abuelo;
            TreeNode padre;
            TreeNode hijo;

            abuelo = tvArbol.Nodes.Add("ALIMENTOS", "ALIMENTOS", 0);

            padre = abuelo.Nodes.Add("FRUTAS", "FRUTAS", 1);
            hijo = padre.Nodes.Add("UVA", "UVA", 2, 2);
            hijo.Tag = "250";
            hijo = padre.Nodes.Add("PERA", "PERA", 2, 2);
            hijo.Tag = "300";
            hijo = padre.Nodes.Add("NARANJA", "NARANJA", 2, 2);
            hijo.Tag = "400";


            padre = abuelo.Nodes.Add("VERDURAS", "VERDURAS", 1);
            hijo = padre.Nodes.Add("ACELGA", "ACELGA", 2, 2);
            hijo.Tag = "250";
            hijo = padre.Nodes.Add("LECHUGA", "LECHUGA", 2, 2);
            hijo.Tag = "150";
            hijo = padre.Nodes.Add("REPOLLO", "REPOLLO", 2, 2);
            hijo.Tag = "233";

        }

        private void tvArbol_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if(e.Node.Level == 2)
            {
                MessageBox.Show("El precio de " + e.Node.Name + " $ " + e.Node.Tag);
            }
        }
    }
}
