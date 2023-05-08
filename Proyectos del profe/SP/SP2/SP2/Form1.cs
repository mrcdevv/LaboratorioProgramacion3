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

namespace SP2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // cargar los datos de los usuarios en el ComboBox
            CUsuario usr = new CUsuario();
            cmbUsuarios.DisplayMember = "Nombre";
            cmbUsuarios.ValueMember = "Usuario";
            cmbUsuarios.DataSource = usr.GetUsuarios();
            // iniciar el timer
            tmrTareas.Interval = 30000; // se dispara cada 30 segundos
            tmrTareas.Enabled = true;
        }

        // evento Tick del Timer
        private void tmrTareas_Tick(object sender, EventArgs e)
        {
            try
            {   // controla la ejecución de tareas pendientes
                CTarea tarea = new CTarea();
                tarea.EjecutarTarea(tmrTareas);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool ValidarPassword()
        {
            bool resultado = false;
            CUsuario usr = new CUsuario();
            String password = usr.GetPasswordUsuario((int)cmbUsuarios.SelectedValue);
            if(password.CompareTo(txtPassword.Text) == 0)
            {
                resultado = true;
            }
            return resultado;
        }

        private bool ValidarDatos()
        {
            DateTime fecha = dtpFecha.Value.Date;
            String hora = dtpHora.Value.ToShortTimeString().Substring(0,5);
            if(fecha.CompareTo(DateTime.Now.Date) < 0)
            {
                throw new Exception("La fecha no puede ser menor a la fecha actual");
            }
            if (fecha.CompareTo(DateTime.Now.Date) == 0 && hora.CompareTo(DateTime.Now.ToString("HH:mm")) < 0)
            {
                throw new Exception("La hora no puede ser manor a la hora actual");
            }
            if(txtRutaDestino.Text == "")
            {
                throw new Exception("Debe seleccionar la ruta destino de las copias");
            }
            if (lstCarpetas.Items.Count == 0)
            {
                throw new Exception("Debe seleccionar al menos una carpeta para copiar");
            }
            return true;
        }

        private void InicializarInterfaz()
        {
            txtPassword.Text = "";
            txtRutaDestino.Text = "";
            lstCarpetas.Items.Clear();
            txtObservacion.Text = "";
        }

        private void btnAceptarTarea_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarPassword())
                {
                    if (ValidarDatos())
                    {
                        // graba una nueva tarea
                        CTarea tarea = new CTarea();
                        // crear una lisa con los nombres de las carpetas a copiar
                        List<String> lista = new List<string>();
                        for (int i = 0; i < lstCarpetas.Items.Count; i++)
                        {
                            lista.Add(lstCarpetas.Items[i].ToString());
                        }
                        DateTime fecha = dtpFecha.Value.Date;
                        // la hora se guarda en formato hora:minutos,
                        // con la hora en formato 24 horas
                        String hora = dtpHora.Value.ToString("HH:mm");
                        // obtener el número del usuario seleccionado en el comboBox
                        int usuario = (int)cmbUsuarios.SelectedValue;
                        String rutaDestino = txtRutaDestino.Text;
                        String observacion = txtObservacion.Text;
                        tarea.AddTarea(fecha, hora, usuario, rutaDestino, observacion, lista);
                        // restablecer la interfaz
                        InicializarInterfaz();
                    }
                }
                else
                {
                    MessageBox.Show("Password incorrecto!.");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // muestra el diálogo para seleccionar la carpeta destino de las copias
        private void btnElegir_Click(object sender, EventArgs e)
        {
            txtRutaDestino.Text = "";
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            dlg.Description = "Seleccione la carpeta destino";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtRutaDestino.Text = dlg.SelectedPath;
            }
            dlg.Dispose();
        }

        private void cmbUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPassword.Text = "";
        }

        // muestra el diálogo para elegir la carpeta a copiar
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            dlg.Description = "Seleccione la carpeta a copiar";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                lstCarpetas.Items.Add(dlg.SelectedPath);
            }
            dlg.Dispose();
        }

        // elimina una carpeta de la lista
        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if(lstCarpetas.SelectedIndex != -1)
            {
                lstCarpetas.Items.RemoveAt(lstCarpetas.SelectedIndex);
            }
        }

        private void btnVerTareas_Click(object sender, EventArgs e)
        {   // muestra el formulario con los datos de las tareas
            Form2 dlg = new Form2();
            dlg.ShowDialog();
        }
    }
}
