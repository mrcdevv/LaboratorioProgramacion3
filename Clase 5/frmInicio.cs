using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase_5
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        Autores objAut;
        Videos objVid;
        string archivo;

        private void frmInicio_Load(object sender, EventArgs e)
        {
            arbol();
            wmpVideo.uiMode = "none";
        }

        private void btnReproducir_Click(object sender, EventArgs e)
        {
            wmpVideo.URL = "./videos/" + archivo;

        }


        private void arbol()
        {
            objAut = new Autores();
            objVid = new Videos();

            TreeNode abuelo;
            TreeNode padre;
            TreeNode hijo;


            abuelo = tv.Nodes.Add("Autores");

            DataTable tAutores = objAut.getTabla();
            DataTable tVideos = objVid.getTabla();

            foreach(DataRow filaAutor in tAutores.Rows)
            {
                padre = abuelo.Nodes.Add(filaAutor["nombre"].ToString());

                foreach(DataRow filaVideos in tVideos.Rows)
                {
                    if (filaAutor["autor"].ToString() == filaVideos["autor"].ToString())
                    {
                        hijo = padre.Nodes.Add(filaVideos["nombre"].ToString());
                        hijo.Tag = filaVideos["archivo"].ToString();
                    }
                }
            }

        }

        private void tv_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            

            if(e.Node.Level == 2)
            {
                archivo = e.Node.Tag.ToString();
            }
        }
    }
}
