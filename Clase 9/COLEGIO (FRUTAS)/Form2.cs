using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COLEGIO
{
    public partial class Form2 : Form
    {

        //string nombres[] = { "JUANA RODRIGUEZ", "PEREZ JUAN" };

        DataTable tabla;
        Alumnos a;

        public Form2()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            grilla.Rows.Clear();

            string quebusco = txtBusco.Text;
            string nombre = "";
            foreach (DataRow fila in tabla.Rows)
            {
                nombre = fila["nombre"].ToString();
                int pos = nombre.IndexOf(quebusco);
                if(pos>-1)
                {
                    grilla.Rows.Add(fila["dni"].ToString(), fila["nombre"].ToString());
                }


            }


        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Alumnos a = new Alumnos();
            tabla = a.getAll();

           
        }
    }
}
