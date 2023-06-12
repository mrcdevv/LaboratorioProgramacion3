namespace Clase_6
{
    partial class frmPrintDocument
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrintDocument));
            this.button1 = new System.Windows.Forms.Button();
            this.PD = new System.Drawing.Printing.PrintDocument();
            this.PPD = new System.Windows.Forms.PrintPreviewDialog();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(138, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(242, 71);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PD
            // 
            this.PD.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.PD_BeginPrint);
            this.PD.EndPrint += new System.Drawing.Printing.PrintEventHandler(this.PD_EndPrint);
            this.PD.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PD_PrintPage);
            // 
            // PPD
            // 
            this.PPD.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.PPD.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.PPD.ClientSize = new System.Drawing.Size(400, 300);
            this.PPD.Document = this.PD;
            this.PPD.Enabled = true;
            this.PPD.Icon = ((System.Drawing.Icon)(resources.GetObject("PPD.Icon")));
            this.PPD.Name = "PPD";
            this.PPD.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 333);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Drawing.Printing.PrintDocument PD;
        private System.Windows.Forms.PrintPreviewDialog PPD;
    }
}

