using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace WindowsFormsApp1
{
    public partial class frmCompareTO : Form
    {
        public frmCompareTO()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("DATA.txt");
            string linea = "";
            while(sr.EndOfStream==false)
            {
                linea = sr.ReadLine();
                string[] vec = linea.Split(',');
                if(vec[1].CompareTo(comboBox1.Text)==0)
                {
                    MessageBox.Show(vec[0]);
                }
            }
            sr.Close();
            sr.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nombre1 = "ANA";
            string nombre2 = "JUAN";
            int valor = nombre1.CompareTo(nombre2);
            MessageBox.Show(valor.ToString());
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
