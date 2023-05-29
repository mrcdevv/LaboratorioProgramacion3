using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase_2
{
    public partial class frmSQLText : Form
    {
        public frmSQLText()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "")
            {
                Personas p = new Personas();

                string color = comboBox1.Text;

                p.Listar(color, dataGridView1);
            }
        }
    }
}
