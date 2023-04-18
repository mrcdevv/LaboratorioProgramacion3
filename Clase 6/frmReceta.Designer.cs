namespace Clase_6
{
    partial class frmReceta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtReceta = new System.Windows.Forms.TextBox();
            this.lblReceta = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.sfdGuardar = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // txtReceta
            // 
            this.txtReceta.Location = new System.Drawing.Point(12, 41);
            this.txtReceta.Multiline = true;
            this.txtReceta.Name = "txtReceta";
            this.txtReceta.Size = new System.Drawing.Size(361, 271);
            this.txtReceta.TabIndex = 0;
            // 
            // lblReceta
            // 
            this.lblReceta.AutoSize = true;
            this.lblReceta.Location = new System.Drawing.Point(12, 13);
            this.lblReceta.Name = "lblReceta";
            this.lblReceta.Size = new System.Drawing.Size(94, 13);
            this.lblReceta.TabIndex = 1;
            this.lblReceta.Text = "Escriba su Receta";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(392, 41);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // frmReceta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 333);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblReceta);
            this.Controls.Add(this.txtReceta);
            this.Name = "frmReceta";
            this.Text = "frmReceta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtReceta;
        private System.Windows.Forms.Label lblReceta;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.SaveFileDialog sfdGuardar;
    }
}