namespace SP3
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Capital");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Colon");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Rio Cuarto");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Punilla");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Cordoba", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Capital");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Belgrano");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Santa Fe", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Capital");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("La Pampa", new System.Windows.Forms.TreeNode[] {
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("INCENDIOS", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode8,
            treeNode10});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Natural",
            "230"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "Accidental",
            "25"}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "Intencional",
            "89"}, -1);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "Desconocido",
            "47"}, -1);
            this.tvwIncendios = new System.Windows.Forms.TreeView();
            this.imLstIconos = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lvwCantidades = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.sspEstado = new System.Windows.Forms.StatusStrip();
            this.lblTitulo = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTotal = new System.Windows.Forms.ToolStripStatusLabel();
            this.sspEstado.SuspendLayout();
            this.SuspendLayout();
            // 
            // tvwIncendios
            // 
            this.tvwIncendios.ImageIndex = 0;
            this.tvwIncendios.ImageList = this.imLstIconos;
            this.tvwIncendios.Location = new System.Drawing.Point(12, 34);
            this.tvwIncendios.Name = "tvwIncendios";
            treeNode1.Name = "Nodo2";
            treeNode1.Text = "Capital";
            treeNode2.Name = "Nodo3";
            treeNode2.Text = "Colon";
            treeNode3.Name = "Nodo4";
            treeNode3.Text = "Rio Cuarto";
            treeNode4.Name = "Nodo5";
            treeNode4.Text = "Punilla";
            treeNode5.Name = "Nodo1";
            treeNode5.Text = "Cordoba";
            treeNode6.Name = "Nodo7";
            treeNode6.Text = "Capital";
            treeNode7.Name = "Nodo8";
            treeNode7.Text = "Belgrano";
            treeNode8.Name = "Nodo6";
            treeNode8.Text = "Santa Fe";
            treeNode9.Name = "Nodo10";
            treeNode9.Text = "Capital";
            treeNode10.Name = "Nodo9";
            treeNode10.Text = "La Pampa";
            treeNode11.ImageIndex = 2;
            treeNode11.Name = "Nodo0";
            treeNode11.Text = "INCENDIOS";
            this.tvwIncendios.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode11});
            this.tvwIncendios.SelectedImageIndex = 0;
            this.tvwIncendios.Size = new System.Drawing.Size(233, 304);
            this.tvwIncendios.TabIndex = 0;
            this.tvwIncendios.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvwIncendios_AfterSelect);
            // 
            // imLstIconos
            // 
            this.imLstIconos.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imLstIconos.ImageStream")));
            this.imLstIconos.TransparentColor = System.Drawing.Color.Transparent;
            this.imLstIconos.Images.SetKeyName(0, "carpeta1.png");
            this.imLstIconos.Images.SetKeyName(1, "carpeta2.png");
            this.imLstIconos.Images.SetKeyName(2, "carpeta3.png");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Incendios";
            // 
            // lvwCantidades
            // 
            this.lvwCantidades.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvwCantidades.HideSelection = false;
            this.lvwCantidades.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4});
            this.lvwCantidades.Location = new System.Drawing.Point(251, 34);
            this.lvwCantidades.Name = "lvwCantidades";
            this.lvwCantidades.Size = new System.Drawing.Size(330, 130);
            this.lvwCantidades.TabIndex = 2;
            this.lvwCantidades.UseCompatibleStateImageBehavior = false;
            this.lvwCantidades.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tipo de Incendio";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Cantidad";
            this.columnHeader2.Width = 100;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cantidades";
            // 
            // sspEstado
            // 
            this.sspEstado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblTitulo,
            this.lblTotal});
            this.sspEstado.Location = new System.Drawing.Point(0, 358);
            this.sspEstado.Name = "sspEstado";
            this.sspEstado.Size = new System.Drawing.Size(598, 22);
            this.sspEstado.TabIndex = 4;
            this.sspEstado.Text = "statusStrip1";
            // 
            // lblTitulo
            // 
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(153, 17);
            this.lblTitulo.Text = "Cantidad Total de Incendios";
            // 
            // lblTotal
            // 
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 17);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 380);
            this.Controls.Add(this.sspEstado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lvwCantidades);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tvwIncendios);
            this.Name = "Form1";
            this.Text = "Consulta de Incendios";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.sspEstado.ResumeLayout(false);
            this.sspEstado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tvwIncendios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvwCantidades;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ImageList imLstIconos;
        private System.Windows.Forms.StatusStrip sspEstado;
        private System.Windows.Forms.ToolStripStatusLabel lblTitulo;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ToolStripStatusLabel lblTotal;
    }
}

