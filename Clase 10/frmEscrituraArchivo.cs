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
    public partial class frmEscrituraArchivo : Form
    {
        public frmEscrituraArchivo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("SAPITO.txt", true);
            sw.WriteLine("HOLA A TODOS");
            sw.Close();
            sw.Dispose();
             
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string linea = "";
            StreamReader sr = new StreamReader("SAPITO.txt");
            while(sr.EndOfStream==false)
            {
                linea = sr.ReadLine();
                MessageBox.Show(linea);
            }
            sr.Close();
            sr.Dispose();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
