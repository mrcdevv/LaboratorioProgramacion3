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

namespace Clase_8
{
    public partial class frmRomanos : Form
    {
        public frmRomanos()
        {
            InitializeComponent();
        }

        private void btnEntrada_Click(object sender, EventArgs e)
        {
            ofd.ShowDialog();
            txtEntrada.Text = ofd.FileName;

        }

        private void btnSalida_Click(object sender, EventArgs e)
        {
            sfd.ShowDialog();
            txtSalida.Text = sfd.FileName;
        }


        private void btnGenerar_Click(object sender, EventArgs e)
        {
            string entrada = txtEntrada.Text;
            string salida = txtSalida.Text;


            StreamReader sr = new StreamReader(entrada);
            StreamWriter sw = new StreamWriter(salida);


            sw.WriteLine("Decimal\t\tRomano");

            while (!(sr.EndOfStream))
            {
                string numero = sr.ReadLine();
                string linea = numero + "\t\t";

                if (int.Parse(numero) <= 3999)
                {
                    linea = linea + Romano(int.Parse(numero));
                }
                else
                {
                    linea = linea + "No se puede converir";
                }

                sw.WriteLine(linea);

            }
            sr.Close();
            sr.Dispose();

            sw.Close();
            sw.Dispose();

            MessageBox.Show("Archivo generado");

        }

        private string Romano(int num)
        {
            string numRomano = "";

            //MIL
            int miles = num / 1000;
            int resto = num % 1000;

            //CIEN
            int centenas = resto / 100;
            resto = resto % 100;
            
            //DIEZ
            int decenas = resto / 10;
            resto = resto % 10;

            //UNO
            int unidad = resto / 1;

            switch(miles)
            {
                case 1: numRomano = numRomano + "M";
                    break;
                case 2:
                    numRomano = numRomano + "MM";
                    break;
                case 3:
                    numRomano = numRomano + "MMM";
                    break;
            }

            switch (centenas)
            {
                case 1:
                    numRomano = numRomano + "C";
                    break;
                case 2:
                    numRomano = numRomano + "CC";
                    break;
                case 3:
                    numRomano = numRomano + "CCC";
                    break;
                case 4:
                    numRomano = numRomano + "CD";
                    break;
                case 5:
                    numRomano = numRomano + "D";
                    break;
                case 6:
                    numRomano = numRomano + "DC";
                    break;
                case 7:
                    numRomano = numRomano + "DCC";
                    break;
                case 8:
                    numRomano = numRomano + "DCCC";
                    break;
                case 9:
                    numRomano = numRomano + "CM";
                    break;
            }

            switch (decenas)
            {
                case 1:
                    numRomano = numRomano + "X";
                    break;
                case 2:
                    numRomano = numRomano + "XX";
                    break;
                case 3:
                    numRomano = numRomano + "XXX";
                    break;
                case 4:
                    numRomano = numRomano + "XL";
                    break;
                case 5:
                    numRomano = numRomano + "L";
                    break;
                case 6:
                    numRomano = numRomano + "LX";
                    break;
                case 7:
                    numRomano = numRomano + "LXX";
                    break;
                case 8:
                    numRomano = numRomano + "LXXX";
                    break;
                case 9:
                    numRomano = numRomano + "XC";
                    break;
            }

            switch (unidad)
            {
                case 1:
                    numRomano = numRomano + "I";
                    break;
                case 2:
                    numRomano = numRomano + "II";
                    break;
                case 3:
                    numRomano = numRomano + "III";
                    break;
                case 4:
                    numRomano = numRomano + "IV";
                    break;
                case 5:
                    numRomano = numRomano + "V";
                    break;
                case 6:
                    numRomano = numRomano + "VI";
                    break;
                case 7:
                    numRomano = numRomano + "VII";
                    break;
                case 8:
                    numRomano = numRomano + "VIII";
                    break;
                case 9:
                    numRomano = numRomano + "IX";
                    break;
            }

            return numRomano;
        }
    }
}
