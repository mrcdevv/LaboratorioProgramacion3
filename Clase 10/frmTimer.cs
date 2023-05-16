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
    public partial class frmTimer : Form
    {
        public frmTimer()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("hh:mm:ss");
            if(dateTimePicker1.Text==label1.Text)
            {
                File.Copy("D:/RECETAS/Pollito.docx", "D:/RECETAS/Pollito_Copia.docx");
                timer1.Enabled = false;
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }
    }
}
