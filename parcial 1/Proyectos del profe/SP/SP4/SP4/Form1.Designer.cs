namespace SP4
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbLocalidad = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lstCultivo = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProduccion = new System.Windows.Forms.TextBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnVerProduccion = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione Localidad";
            // 
            // cmbLocalidad
            // 
            this.cmbLocalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLocalidad.FormattingEnabled = true;
            this.cmbLocalidad.Location = new System.Drawing.Point(28, 44);
            this.cmbLocalidad.Name = "cmbLocalidad";
            this.cmbLocalidad.Size = new System.Drawing.Size(259, 21);
            this.cmbLocalidad.TabIndex = 1;
            this.cmbLocalidad.SelectedIndexChanged += new System.EventHandler(this.cmbLocalidad_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Seleccione Tipo de Cultivo";
            // 
            // lstCultivo
            // 
            this.lstCultivo.FormattingEnabled = true;
            this.lstCultivo.Location = new System.Drawing.Point(28, 107);
            this.lstCultivo.Name = "lstCultivo";
            this.lstCultivo.Size = new System.Drawing.Size(259, 147);
            this.lstCultivo.TabIndex = 3;
            this.lstCultivo.SelectedIndexChanged += new System.EventHandler(this.lstCultivo_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(327, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Producción en Toneladas";
            // 
            // txtProduccion
            // 
            this.txtProduccion.Location = new System.Drawing.Point(330, 45);
            this.txtProduccion.Name = "txtProduccion";
            this.txtProduccion.Size = new System.Drawing.Size(126, 20);
            this.txtProduccion.TabIndex = 5;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(364, 91);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(92, 38);
            this.btnActualizar.TabIndex = 6;
            this.btnActualizar.Text = "&Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnVerProduccion
            // 
            this.btnVerProduccion.Location = new System.Drawing.Point(364, 153);
            this.btnVerProduccion.Name = "btnVerProduccion";
            this.btnVerProduccion.Size = new System.Drawing.Size(92, 38);
            this.btnVerProduccion.TabIndex = 7;
            this.btnVerProduccion.Text = "&Ver Produccion";
            this.btnVerProduccion.UseVisualStyleBackColor = true;
            this.btnVerProduccion.Click += new System.EventHandler(this.btnVerProduccion_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(364, 215);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(92, 38);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 276);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnVerProduccion);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.txtProduccion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstCultivo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbLocalidad);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Registro de Producción por Localidad y Cultivo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbLocalidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstCultivo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProduccion;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnVerProduccion;
        private System.Windows.Forms.Button btnSalir;
    }
}

