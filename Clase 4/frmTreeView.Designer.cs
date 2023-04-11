namespace Clase_4
{
    partial class frmTreeView
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTreeView));
            this.tvArbol = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // tvArbol
            // 
            this.tvArbol.ImageIndex = 0;
            this.tvArbol.ImageList = this.imageList1;
            this.tvArbol.Location = new System.Drawing.Point(13, 12);
            this.tvArbol.Name = "tvArbol";
            this.tvArbol.SelectedImageIndex = 0;
            this.tvArbol.Size = new System.Drawing.Size(362, 249);
            this.tvArbol.TabIndex = 0;
            this.tvArbol.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvArbol_NodeMouseClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Abbe.png");
            this.imageList1.Images.SetKeyName(1, "Homer_Simpson.png");
            this.imageList1.Images.SetKeyName(2, "580b57fbd9996e24bc43bd17.png");
            // 
            // frmTreeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 307);
            this.Controls.Add(this.tvArbol);
            this.Name = "frmTreeView";
            this.Text = "TreeView y ImageList";
            this.Load += new System.EventHandler(this.frmArboles_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tvArbol;
        private System.Windows.Forms.ImageList imageList1;
    }
}

