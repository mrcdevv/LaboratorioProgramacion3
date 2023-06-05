namespace Clase_4
{
    partial class frmPictureBox
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
            this.pic = new System.Windows.Forms.PictureBox();
            this.btnGraficar1 = new System.Windows.Forms.Button();
            this.btnGraficar2 = new System.Windows.Forms.Button();
            this.btnGraficar3 = new System.Windows.Forms.Button();
            this.btnGraficar4 = new System.Windows.Forms.Button();
            this.btnTablero = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // pic
            // 
            this.pic.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic.Location = new System.Drawing.Point(36, 22);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(400, 400);
            this.pic.TabIndex = 0;
            this.pic.TabStop = false;
            // 
            // btnGraficar1
            // 
            this.btnGraficar1.Location = new System.Drawing.Point(483, 22);
            this.btnGraficar1.Name = "btnGraficar1";
            this.btnGraficar1.Size = new System.Drawing.Size(254, 37);
            this.btnGraficar1.TabIndex = 1;
            this.btnGraficar1.Text = "GRAFICAR LINEAS";
            this.btnGraficar1.UseVisualStyleBackColor = true;
            this.btnGraficar1.Click += new System.EventHandler(this.btnGraficar_Click);
            // 
            // btnGraficar2
            // 
            this.btnGraficar2.Location = new System.Drawing.Point(483, 77);
            this.btnGraficar2.Name = "btnGraficar2";
            this.btnGraficar2.Size = new System.Drawing.Size(254, 37);
            this.btnGraficar2.TabIndex = 2;
            this.btnGraficar2.Text = "GRAFICAR 4 ELIPSES ROJAS";
            this.btnGraficar2.UseVisualStyleBackColor = true;
            this.btnGraficar2.Click += new System.EventHandler(this.btnGraficar2_Click);
            // 
            // btnGraficar3
            // 
            this.btnGraficar3.Location = new System.Drawing.Point(483, 131);
            this.btnGraficar3.Name = "btnGraficar3";
            this.btnGraficar3.Size = new System.Drawing.Size(254, 37);
            this.btnGraficar3.TabIndex = 3;
            this.btnGraficar3.Text = "GRAFICAR ESCUDO RIVER";
            this.btnGraficar3.UseVisualStyleBackColor = true;
            this.btnGraficar3.Click += new System.EventHandler(this.btnGraficar3_Click);
            // 
            // btnGraficar4
            // 
            this.btnGraficar4.Location = new System.Drawing.Point(483, 184);
            this.btnGraficar4.Name = "btnGraficar4";
            this.btnGraficar4.Size = new System.Drawing.Size(254, 37);
            this.btnGraficar4.TabIndex = 4;
            this.btnGraficar4.Text = "GRAFICAR CIRCULO VERDE";
            this.btnGraficar4.UseVisualStyleBackColor = true;
            this.btnGraficar4.Click += new System.EventHandler(this.btnGraficar4_Click);
            // 
            // btnTablero
            // 
            this.btnTablero.Location = new System.Drawing.Point(483, 237);
            this.btnTablero.Name = "btnTablero";
            this.btnTablero.Size = new System.Drawing.Size(254, 37);
            this.btnTablero.TabIndex = 5;
            this.btnTablero.Text = "TAREA: TABLERO DAMAS";
            this.btnTablero.UseVisualStyleBackColor = true;
            this.btnTablero.Click += new System.EventHandler(this.btnTablero_Click);
            // 
            // frmPictureBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 450);
            this.Controls.Add(this.btnTablero);
            this.Controls.Add(this.btnGraficar4);
            this.Controls.Add(this.btnGraficar3);
            this.Controls.Add(this.btnGraficar2);
            this.Controls.Add(this.btnGraficar1);
            this.Controls.Add(this.pic);
            this.Name = "frmPictureBox";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmPictureBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Button btnGraficar1;
        private System.Windows.Forms.Button btnGraficar2;
        private System.Windows.Forms.Button btnGraficar3;
        private System.Windows.Forms.Button btnGraficar4;
        private System.Windows.Forms.Button btnTablero;
    }
}

