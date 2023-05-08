using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics; // permite usar Trace

namespace SP1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // se activa el Listener de EventLog y el uso de Trace
            Trace.Listeners.Add(new EventLogTraceListener("AppFarmaciaEventLog"));
            Trace.AutoFlush = true;
            Trace.Indent();
            Trace.WriteLine("Iniciando aplicación de Farmacia");
            try
            {
                // cargar el comboBox con los datos de los Laboratorios
                CLaboratorio lab = new CLaboratorio();
                cmbLaboratorio.DisplayMember = "Nombre";
                cmbLaboratorio.ValueMember = "Laboratorio";
                cmbLaboratorio.DataSource = lab.GetLaboratorios();
                lab.Dispose();
                Trace.WriteLine("Datos de Laboratorios obtenidos " + cmbLaboratorio.Items.Count.ToString());
            }
            catch(LaboratorioException lex)
            {
                MessageBox.Show(lex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                // se inicia una actualización con el archivo seleccionado
                CActualizacion actualizacion = new CActualizacion();
                bool res = actualizacion.Actualizar(txtArchivo.Text,
                    cmbLaboratorio.Text,
                    int.Parse(cmbLaboratorio.SelectedValue.ToString()));
                if (res)
                {
                    MessageBox.Show("Actualización finalizada correctamente");
                }
                actualizacion.Dispose();
            }
            catch(ActualizacionException aex)
            {
                MessageBox.Show(aex.Message);
            }
        }

        // buscar y seleccionar el archivo de Medicamentos
        private void btnExaminar_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Archivo de Medicamentos";
            dlg.Filter = "Archivos txt|*.txt";
            dlg.FilterIndex = 0;
            dlg.InitialDirectory = Application.StartupPath;
            dlg.RestoreDirectory = true;
            if(dlg.ShowDialog()== DialogResult.OK)
            {
                txtArchivo.Text = dlg.FileName;
                btnActualizar.Enabled = true;
                btnReporte.Enabled = true;
                Trace.WriteLine("Se seleccionó el archivo " + dlg.FileName);
            }
            else
            {
                txtArchivo.Text = "";
                btnActualizar.Enabled = false;
                btnReporte.Enabled = false;
            }
        }

        // genera el reporte con los datos actualizados
        private void btnReporte_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Title = "Guardar Reporte";
            dlg.Filter = "Archivos de Reporte (.txt)|*.txt";
            dlg.FilterIndex = 0;
            dlg.InitialDirectory = Application.StartupPath;
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    CActualizacion actualizacion = new CActualizacion();
                    actualizacion.GenerarReporte(dlg.FileName);
                    MessageBox.Show("Reporte Generado. (" + dlg.FileName + ")");
                    actualizacion.Dispose();
                    Trace.WriteLine("Reporte generado: " + dlg.FileName);
                }
                catch(ActualizacionException aex)
                {
                    MessageBox.Show(aex.Message);
                }
                finally
                {
                    dlg.Dispose();
                }
            }
        }

        // evento del ComboBox para actualizar el contenido del TextBox
        // con el nombre del archivo
        private void cmbLaboratorio_SelectedIndexChanged(object sender, EventArgs e)
        {
            Trace.WriteLine("Se seleccionó el laboratorio " + cmbLaboratorio.Text);
            txtArchivo.Text = "";
            btnActualizar.Enabled = false;
            btnReporte.Enabled = false;
        }
    }
}
