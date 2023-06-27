using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

// Libreria para hacer dibujos sobre las cosas
using System.Drawing;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Libreria para graficar
using System.Windows.Forms.DataVisualization.Charting;

namespace sp5_cerrajeria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Objeto para poder dibujar
        Graphics estanterias;

        Articulos art;
        Estanterias est;

        private void Form1_Load(object sender, EventArgs e)
        {
            // OBLIGATORIO!
            try
            {
                art = new Articulos();
                est = new Estanterias();
            }
            catch (Exception)
            {
                MessageBox.Show("Tonto", "Error", MessageBoxButtons.OK);
                Application.Exit();
            }
            

            estanterias = pictureBox.CreateGraphics();
        }

        private void cmdConsultar_Click(object sender, EventArgs e)
        {
            int idEstanteria = -1;

            // Cargar datos

            DataTable dt = new DataTable();
            dt = est.Get_Tabla();

            // Obtengo la fila correspondiente al codigo de articulo ingresado
            DataRow fila = art.Get_Value(Convert.ToInt32(txtCodigo.Text));

            // Si encontro el codigo...
            if (fila != null)
            {

                lblNombreArticulo.Text = fila["Nombre"].ToString();
                lblPrecio.Text = fila["Precio"].ToString();

                
                foreach(DataRow filaEstanteria in dt.Rows)
                {
                    // Busco la informacion relacionada en la tabla estanterias
                    if (filaEstanteria["CodigoArticulo"].ToString() == fila[0].ToString())
                    {
                        lblStock.Text = filaEstanteria["Stock"].ToString();
                        // Guardo en la estanteria que se encuentra el articulo para despues pintarla en el picture box
                        idEstanteria = Convert.ToInt32(filaEstanteria["NumeroEstanteria"]);
                    } 
                }

            } else
            {
                MessageBox.Show("El codigo ingresado no existe", "Error", MessageBoxButtons.OK);
            }

            // Dibujar
            int x;
            int y;
            int numEstanteria = 1;

            Font fuente = new Font("Verdana", 8, FontStyle.Bold);

            // Limpiar el picture box
            estanterias.Clear(Color.White);

            // Filas del picture box
            for (y = 0; y < 240 - 40; y += 40)
            {
                // Columnas del picture box
                for (x = 0; x < 420 - 60; x += 60)
                {

                    estanterias.DrawRectangle(Pens.Black, x, y, 60, 40);

                    // Si la id de la estanteria es igual a la posicion cuadrado que se dibujo...
                    if (idEstanteria == numEstanteria)
                    {
                        //... pintalo de rojo
                        estanterias.FillRectangle(Brushes.Red, x, y, 60, 40);
                        idEstanteria = -1;
                    }

                    estanterias.DrawString(numEstanteria.ToString(), fuente, Brushes.Black, x, y);

                    numEstanteria++;

                }
            }

        }

        // Imprimir el documento
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            DataTable dtArt = new DataTable();
            DataTable dtEst = new DataTable();

            dtArt = art.Get_Tabla();
            dtEst = est.Get_Tabla();


            Font subtitulo = new Font("Verdana", 14);
            Font descripcion = new Font("Verdana", 12, FontStyle.Italic);
            Font titulo = new Font("Comic Sans MS", 25, FontStyle.Bold);
            Font encabezado = new Font("Maluma", 15, FontStyle.Underline);

            // Empezar a escribir arriba a la izquiera
            int x = e.MarginBounds.Left;
            int y = e.MarginBounds.Top;

            e.Graphics.DrawString("Maluma Maluma", titulo, Brushes.Black, x, y);
            y = y + titulo.Height * 2; // Obligatorio, porque sino escribe todo en el mismo lugar

            e.Graphics.DrawString("descripcion de maluma maluma, la puta que te pario", descripcion, Brushes.Black, x, y);
            y = y + descripcion.Height * 2;

            e.Graphics.DrawString("Articulos:", encabezado, Brushes.Black, x, y);
            y = y + encabezado.Height *2;

            e.Graphics.DrawString("Código", subtitulo, Brushes.Black, x, y);
            e.Graphics.DrawString("Nombre", subtitulo, Brushes.Black, x+150, y);
            e.Graphics.DrawString("Precio", subtitulo, Brushes.Black, x+300, y);

            y = y + subtitulo.Height * 2;

            foreach (DataRow fArticulo in dtArt.Rows)
            {
                e.Graphics.DrawString(fArticulo[0].ToString(), descripcion, Brushes.Black, x, y);
                e.Graphics.DrawString(fArticulo[1].ToString(), descripcion, Brushes.Black, x + 150, y);
                e.Graphics.DrawString(fArticulo[2].ToString(), descripcion, Brushes.Black, x + 300, y);
                y = y + descripcion.Height;
            }

            y = y + titulo.Height * 2;

            e.Graphics.DrawString("Estanterias:", encabezado, Brushes.Black, x, y);
            y = y + encabezado.Height * 2;

            e.Graphics.DrawString("IdArticulo", subtitulo, Brushes.Black, x, y);
            e.Graphics.DrawString("IdEstanteria", subtitulo, Brushes.Black, x + 150, y);
            e.Graphics.DrawString("Stock", subtitulo, Brushes.Black, x + 300, y);

            y = y + subtitulo.Height * 2;

            foreach (DataRow fEstanteria in dtEst.Rows)
            {
                e.Graphics.DrawString(fEstanteria[0].ToString(), descripcion, Brushes.Black, x, y);
                e.Graphics.DrawString(fEstanteria[1].ToString(), descripcion, Brushes.Black, x + 150, y);
                e.Graphics.DrawString(fEstanteria[2].ToString(), descripcion, Brushes.Black, x + 300, y);
                y = y + descripcion.Height;
            }

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            // Obligatorio pa imprimir
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        // Graficar
        private void tb2_Enter(object sender, EventArgs e)
        {
            DataTable dtArt = new DataTable();
            DataTable dtEst = new DataTable();

            dtArt = art.Get_Tabla();
            dtEst = est.Get_Tabla();


            ch.Series.Clear();


            Series serie = ch.Series.Add("Articulos");

            foreach (DataRow filaArticulo in dtArt.Rows)
            {
                foreach (DataRow filaEstanteria in dtEst.Rows)
                {
                    if((int)filaArticulo[0] == (int)filaEstanteria[0])
                    {
                        // Las dos opciones se pueden usar, si usas la segunda opcion, no hace falta que crees 'Series serie = ch.Series.Add("Articulos")'
                        serie.Points.AddXY(filaArticulo[1], filaEstanteria[2]);
                        //ch.Series.Add(filaArticulo[1].ToString()).Points.Add((int)filaEstanteria[2]);

                    }

                }
            }

        }
    }
}
