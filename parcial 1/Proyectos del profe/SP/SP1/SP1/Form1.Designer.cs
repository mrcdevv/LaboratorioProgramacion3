namespace SP1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnReporte = new System.Windows.Forms.Button();
            this.btnExaminar = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtArchivo = new System.Windows.Forms.TextBox();
            this.cmbLaboratorio = new System.Windows.Forms.ComboBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnActualizar
            // 
            this.btnActualizar.Enabled = false;
            this.btnActualizar.Location = new System.Drawing.Point(403, 169);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(104, 41);
            this.btnActualizar.TabIndex = 33;
            this.btnActualizar.Text = "&Actualizar Precios";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnReporte
            // 
            this.btnReporte.Enabled = false;
            this.btnReporte.Location = new System.Drawing.Point(403, 225);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(104, 41);
            this.btnReporte.TabIndex = 32;
            this.btnReporte.Text = "&Generar Reporte";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // btnExaminar
            // 
            this.btnExaminar.Location = new System.Drawing.Point(403, 86);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(104, 35);
            this.btnExaminar.TabIndex = 28;
            this.btnExaminar.Text = "&Examinar";
            this.btnExaminar.UseVisualStyleBackColor = true;
            this.btnExaminar.Click += new System.EventHandler(this.btnExaminar_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(21, 108);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(318, 13);
            this.Label2.TabIndex = 27;
            this.Label2.Text = "Archivo de medicamentos del laboratorio con precios actualizados";
            // 
            // txtArchivo
            // 
            this.txtArchivo.Location = new System.Drawing.Point(24, 127);
            this.txtArchivo.Name = "txtArchivo";
            this.txtArchivo.Size = new System.Drawing.Size(483, 20);
            this.txtArchivo.TabIndex = 26;
            // 
            // cmbLaboratorio
            // 
            this.cmbLaboratorio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLaboratorio.FormattingEnabled = true;
            this.cmbLaboratorio.Location = new System.Drawing.Point(24, 39);
            this.cmbLaboratorio.Name = "cmbLaboratorio";
            this.cmbLaboratorio.Size = new System.Drawing.Size(230, 21);
            this.cmbLaboratorio.TabIndex = 25;
            this.cmbLaboratorio.SelectedIndexChanged += new System.EventHandler(this.cmbLaboratorio_SelectedIndexChanged);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(21, 19);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(60, 13);
            this.Label1.TabIndex = 24;
            this.Label1.Text = "Laboratorio";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 286);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.btnExaminar);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.txtArchivo);
            this.Controls.Add(this.cmbLaboratorio);
            this.Controls.Add(this.Label1);
            this.Name = "Form1";
            this.Text = "Farmacia - Actualización de Precios";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnActualizar;
        internal System.Windows.Forms.Button btnReporte;
        internal System.Windows.Forms.Button btnExaminar;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtArchivo;
        internal System.Windows.Forms.ComboBox cmbLaboratorio;
        internal System.Windows.Forms.Label Label1;
    }
}

