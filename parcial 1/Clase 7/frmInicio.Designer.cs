namespace Clase_7
{
    partial class frmInicio
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
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblMinima = new System.Windows.Forms.Label();
            this.lblMaxima = new System.Windows.Forms.Label();
            this.lstLocalidad = new System.Windows.Forms.ComboBox();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.txtMinima = new System.Windows.Forms.TextBox();
            this.txtMaxima = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblLocalidad.Location = new System.Drawing.Point(31, 31);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(77, 20);
            this.lblLocalidad.TabIndex = 0;
            this.lblLocalidad.Text = "Localidad";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblFecha.Location = new System.Drawing.Point(31, 64);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(54, 20);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "Fecha";
            // 
            // lblMinima
            // 
            this.lblMinima.AutoSize = true;
            this.lblMinima.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblMinima.Location = new System.Drawing.Point(31, 103);
            this.lblMinima.Name = "lblMinima";
            this.lblMinima.Size = new System.Drawing.Size(59, 20);
            this.lblMinima.TabIndex = 2;
            this.lblMinima.Text = "Minima";
            // 
            // lblMaxima
            // 
            this.lblMaxima.AutoSize = true;
            this.lblMaxima.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblMaxima.Location = new System.Drawing.Point(31, 144);
            this.lblMaxima.Name = "lblMaxima";
            this.lblMaxima.Size = new System.Drawing.Size(63, 20);
            this.lblMaxima.TabIndex = 3;
            this.lblMaxima.Text = "Maxima";
            // 
            // lstLocalidad
            // 
            this.lstLocalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstLocalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lstLocalidad.FormattingEnabled = true;
            this.lstLocalidad.Location = new System.Drawing.Point(145, 28);
            this.lstLocalidad.Name = "lstLocalidad";
            this.lstLocalidad.Size = new System.Drawing.Size(142, 28);
            this.lstLocalidad.TabIndex = 4;
            // 
            // dtp
            // 
            this.dtp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp.Location = new System.Drawing.Point(145, 64);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(142, 26);
            this.dtp.TabIndex = 5;
            // 
            // txtMinima
            // 
            this.txtMinima.Enabled = false;
            this.txtMinima.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtMinima.Location = new System.Drawing.Point(145, 100);
            this.txtMinima.Name = "txtMinima";
            this.txtMinima.Size = new System.Drawing.Size(142, 26);
            this.txtMinima.TabIndex = 6;
            // 
            // txtMaxima
            // 
            this.txtMaxima.Enabled = false;
            this.txtMaxima.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtMaxima.Location = new System.Drawing.Point(145, 141);
            this.txtMaxima.Name = "txtMaxima";
            this.txtMaxima.Size = new System.Drawing.Size(142, 26);
            this.txtMaxima.TabIndex = 7;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnBuscar.Location = new System.Drawing.Point(93, 192);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(89, 32);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 258);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtMaxima);
            this.Controls.Add(this.txtMinima);
            this.Controls.Add(this.dtp);
            this.Controls.Add(this.lstLocalidad);
            this.Controls.Add(this.lblMaxima);
            this.Controls.Add(this.lblMinima);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblLocalidad);
            this.Name = "frmInicio";
            this.Text = "Minima y Maxima por localidad y fecha";
            this.Load += new System.EventHandler(this.frmInicio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblMinima;
        private System.Windows.Forms.Label lblMaxima;
        private System.Windows.Forms.ComboBox lstLocalidad;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.TextBox txtMinima;
        private System.Windows.Forms.TextBox txtMaxima;
        private System.Windows.Forms.Button btnBuscar;
    }
}

