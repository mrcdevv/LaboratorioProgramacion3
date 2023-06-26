using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ELECCIONES
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string sql = @"
                SELECT L.gobernador, SUM(V.votos) AS votos
                FROM Listas L
                INNER JOIN Votos V ON L.lista=V.lista
                GROUP BY L.gobernador
                ORDER BY SUM(V.votos) DESC
            ";

            Datos d = new Datos();

            //DataTable td = d.getData("SELECT * FROM Departamentos WHERE departamento < 4");
            //DataTable tl = d.getData("SELECT * FROM Listas");
            //DataTable tv = d.getData("SELECT * FROM Votos");

            dataGridView1.DataSource = d.getData(sql);

            


        }
    }
}
