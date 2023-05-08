using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace SP3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lvwCantidades.Items.Clear();
            tvwIncendios.Nodes.Clear();
            CProvincia provincia = new CProvincia();
            provincia.CargarTreeView(tvwIncendios);
            provincia.Dispose();
        }

        private void tvwIncendios_AfterSelect(object sender, TreeViewEventArgs e)
        {
            CIncendio incendio = new CIncendio();
            int Total;
            // determinar el nivel del nodo seleccionado
            TreeNode nodo = e.Node;
            switch (nodo.Level)
            {
                case 0: // es el nodo raiz
                    Total = incendio.ObtenerIncendios(lvwCantidades);
                    sspEstado.Items["lblTotal"].Text = Total.ToString();
                    break;

                case 1: // es un nodo de Provincia
                    Total = incendio.ObtenerIncendiosPorProvincia(int.Parse(nodo.Name), lvwCantidades);
                    sspEstado.Items["lblTotal"].Text = "Provincia " + nodo.Text + ": " + Total.ToString();
                    break;

                case 2: // es un nodo de Departamento
                    Total = incendio.ObtenerIncendiosPorDepartamento(int.Parse(nodo.Name), lvwCantidades);
                    sspEstado.Items["lblTotal"].Text = "Departamento " + nodo.Text + ": " + Total.ToString();
                    break;
            }
            // liberar los recursos
            incendio.Dispose();
        }
    }
}
