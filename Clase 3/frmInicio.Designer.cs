namespace Clase_3
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
            this.lblEspecialidad = new System.Windows.Forms.Label();
            this.lstEspecialidad = new System.Windows.Forms.ComboBox();
            this.btnVer = new System.Windows.Forms.Button();
            this.dgvMedicos = new System.Windows.Forms.DataGridView();
            this.btnForm2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEspecialidad
            // 
            this.lblEspecialidad.AutoSize = true;
            this.lblEspecialidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblEspecialidad.Location = new System.Drawing.Point(31, 22);
            this.lblEspecialidad.Name = "lblEspecialidad";
            this.lblEspecialidad.Size = new System.Drawing.Size(179, 20);
            this.lblEspecialidad.TabIndex = 0;
            this.lblEspecialidad.Text = "Seleccione especialidad";
            // 
            // lstEspecialidad
            // 
            this.lstEspecialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstEspecialidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lstEspecialidad.FormattingEnabled = true;
            this.lstEspecialidad.Location = new System.Drawing.Point(34, 54);
            this.lstEspecialidad.Name = "lstEspecialidad";
            this.lstEspecialidad.Size = new System.Drawing.Size(240, 28);
            this.lstEspecialidad.TabIndex = 1;
            // 
            // btnVer
            // 
            this.btnVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnVer.Location = new System.Drawing.Point(325, 22);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(77, 28);
            this.btnVer.TabIndex = 2;
            this.btnVer.Text = "Ver";
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // dgvMedicos
            // 
            this.dgvMedicos.AllowUserToAddRows = false;
            this.dgvMedicos.AllowUserToDeleteRows = false;
            this.dgvMedicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicos.Location = new System.Drawing.Point(34, 111);
            this.dgvMedicos.Name = "dgvMedicos";
            this.dgvMedicos.ReadOnly = true;
            this.dgvMedicos.Size = new System.Drawing.Size(368, 150);
            this.dgvMedicos.TabIndex = 3;
            // 
            // btnForm2
            // 
            this.btnForm2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnForm2.Location = new System.Drawing.Point(325, 56);
            this.btnForm2.Name = "btnForm2";
            this.btnForm2.Size = new System.Drawing.Size(77, 28);
            this.btnForm2.TabIndex = 4;
            this.btnForm2.Text = "Form2";
            this.btnForm2.UseVisualStyleBackColor = true;
            this.btnForm2.Click += new System.EventHandler(this.btnForm2_Click);
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 299);
            this.Controls.Add(this.btnForm2);
            this.Controls.Add(this.dgvMedicos);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.lstEspecialidad);
            this.Controls.Add(this.lblEspecialidad);
            this.Name = "frmInicio";
            this.Text = "Consulta de medicos por especialidad";
            this.Load += new System.EventHandler(this.frmInicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEspecialidad;
        private System.Windows.Forms.ComboBox lstEspecialidad;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.DataGridView dgvMedicos;
        private System.Windows.Forms.Button btnForm2;
    }
}

