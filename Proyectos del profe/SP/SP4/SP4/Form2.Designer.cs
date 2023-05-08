
namespace SP4
{
    partial class Form2
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabGraficos = new System.Windows.Forms.TabControl();
            this.tabProduccionPorLocalidad = new System.Windows.Forms.TabPage();
            this.btnGraficar = new System.Windows.Forms.Button();
            this.chtGrafico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cmbLocalidad = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabProduccionTotal = new System.Windows.Forms.TabPage();
            this.btnGraficarTodo = new System.Windows.Forms.Button();
            this.chtGraficoTotal = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabGraficos.SuspendLayout();
            this.tabProduccionPorLocalidad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtGrafico)).BeginInit();
            this.tabProduccionTotal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtGraficoTotal)).BeginInit();
            this.SuspendLayout();
            // 
            // tabGraficos
            // 
            this.tabGraficos.Controls.Add(this.tabProduccionPorLocalidad);
            this.tabGraficos.Controls.Add(this.tabProduccionTotal);
            this.tabGraficos.Location = new System.Drawing.Point(12, 12);
            this.tabGraficos.Name = "tabGraficos";
            this.tabGraficos.SelectedIndex = 0;
            this.tabGraficos.Size = new System.Drawing.Size(574, 411);
            this.tabGraficos.TabIndex = 0;
            // 
            // tabProduccionPorLocalidad
            // 
            this.tabProduccionPorLocalidad.Controls.Add(this.btnGraficar);
            this.tabProduccionPorLocalidad.Controls.Add(this.chtGrafico);
            this.tabProduccionPorLocalidad.Controls.Add(this.cmbLocalidad);
            this.tabProduccionPorLocalidad.Controls.Add(this.label1);
            this.tabProduccionPorLocalidad.Location = new System.Drawing.Point(4, 22);
            this.tabProduccionPorLocalidad.Name = "tabProduccionPorLocalidad";
            this.tabProduccionPorLocalidad.Padding = new System.Windows.Forms.Padding(3);
            this.tabProduccionPorLocalidad.Size = new System.Drawing.Size(566, 385);
            this.tabProduccionPorLocalidad.TabIndex = 0;
            this.tabProduccionPorLocalidad.Text = "Producción Por Localidad";
            this.tabProduccionPorLocalidad.UseVisualStyleBackColor = true;
            // 
            // btnGraficar
            // 
            this.btnGraficar.Location = new System.Drawing.Point(461, 17);
            this.btnGraficar.Name = "btnGraficar";
            this.btnGraficar.Size = new System.Drawing.Size(86, 37);
            this.btnGraficar.TabIndex = 3;
            this.btnGraficar.Text = "&Graficar";
            this.btnGraficar.UseVisualStyleBackColor = true;
            this.btnGraficar.Click += new System.EventHandler(this.btnGraficar_Click);
            // 
            // chtGrafico
            // 
            this.chtGrafico.BorderlineColor = System.Drawing.Color.Black;
            this.chtGrafico.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea6.Name = "ChartArea1";
            this.chtGrafico.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chtGrafico.Legends.Add(legend6);
            this.chtGrafico.Location = new System.Drawing.Point(6, 69);
            this.chtGrafico.Name = "chtGrafico";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chtGrafico.Series.Add(series6);
            this.chtGrafico.Size = new System.Drawing.Size(554, 300);
            this.chtGrafico.TabIndex = 2;
            this.chtGrafico.Text = "chart1";
            // 
            // cmbLocalidad
            // 
            this.cmbLocalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLocalidad.FormattingEnabled = true;
            this.cmbLocalidad.Location = new System.Drawing.Point(23, 33);
            this.cmbLocalidad.Name = "cmbLocalidad";
            this.cmbLocalidad.Size = new System.Drawing.Size(236, 21);
            this.cmbLocalidad.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Localidad";
            // 
            // tabProduccionTotal
            // 
            this.tabProduccionTotal.Controls.Add(this.btnGraficarTodo);
            this.tabProduccionTotal.Controls.Add(this.chtGraficoTotal);
            this.tabProduccionTotal.Location = new System.Drawing.Point(4, 22);
            this.tabProduccionTotal.Name = "tabProduccionTotal";
            this.tabProduccionTotal.Padding = new System.Windows.Forms.Padding(3);
            this.tabProduccionTotal.Size = new System.Drawing.Size(566, 385);
            this.tabProduccionTotal.TabIndex = 1;
            this.tabProduccionTotal.Text = "Producción Total";
            this.tabProduccionTotal.UseVisualStyleBackColor = true;
            // 
            // btnGraficarTodo
            // 
            this.btnGraficarTodo.Location = new System.Drawing.Point(458, 20);
            this.btnGraficarTodo.Name = "btnGraficarTodo";
            this.btnGraficarTodo.Size = new System.Drawing.Size(86, 35);
            this.btnGraficarTodo.TabIndex = 1;
            this.btnGraficarTodo.Text = "&Graficar";
            this.btnGraficarTodo.UseVisualStyleBackColor = true;
            this.btnGraficarTodo.Click += new System.EventHandler(this.btnGraficarTodo_Click);
            // 
            // chtGraficoTotal
            // 
            this.chtGraficoTotal.BorderlineColor = System.Drawing.Color.Black;
            this.chtGraficoTotal.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea5.Name = "ChartArea1";
            this.chtGraficoTotal.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chtGraficoTotal.Legends.Add(legend5);
            this.chtGraficoTotal.Location = new System.Drawing.Point(6, 61);
            this.chtGraficoTotal.Name = "chtGraficoTotal";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chtGraficoTotal.Series.Add(series5);
            this.chtGraficoTotal.Size = new System.Drawing.Size(554, 318);
            this.chtGraficoTotal.TabIndex = 0;
            this.chtGraficoTotal.Text = "chart1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 432);
            this.Controls.Add(this.tabGraficos);
            this.Name = "Form2";
            this.Text = "Gráficos de Producción";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.tabGraficos.ResumeLayout(false);
            this.tabProduccionPorLocalidad.ResumeLayout(false);
            this.tabProduccionPorLocalidad.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtGrafico)).EndInit();
            this.tabProduccionTotal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chtGraficoTotal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabGraficos;
        private System.Windows.Forms.TabPage tabProduccionPorLocalidad;
        private System.Windows.Forms.Button btnGraficar;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtGrafico;
        private System.Windows.Forms.ComboBox cmbLocalidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabProduccionTotal;
        private System.Windows.Forms.Button btnGraficarTodo;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtGraficoTotal;
    }
}