namespace ing_software_PCCV.Graficos
{
    partial class GrCategorias
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chValor = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chCantidad = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chValor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // chValor
            // 
            chartArea1.Name = "ChartArea1";
            this.chValor.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chValor.Legends.Add(legend1);
            this.chValor.Location = new System.Drawing.Point(69, 144);
            this.chValor.Name = "chValor";
            this.chValor.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.IsValueShownAsLabel = true;
            series1.IsXValueIndexed = true;
            series1.LabelForeColor = System.Drawing.Color.White;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chValor.Series.Add(series1);
            this.chValor.Size = new System.Drawing.Size(432, 331);
            this.chValor.TabIndex = 0;
            this.chValor.Text = "chart1";
            // 
            // chCantidad
            // 
            chartArea2.Name = "ChartArea1";
            this.chCantidad.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chCantidad.Legends.Add(legend2);
            this.chCantidad.Location = new System.Drawing.Point(555, 144);
            this.chCantidad.Name = "chCantidad";
            this.chCantidad.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.IsValueShownAsLabel = true;
            series2.LabelForeColor = System.Drawing.Color.White;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chCantidad.Series.Add(series2);
            this.chCantidad.Size = new System.Drawing.Size(409, 318);
            this.chCantidad.TabIndex = 1;
            this.chCantidad.Text = "chart2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft MHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Categorías con más dinero recaudado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft MHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(577, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(350, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Categorías con cantidades de productos vendidos";
            // 
            // GrCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1005, 507);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chCantidad);
            this.Controls.Add(this.chValor);
            this.Name = "GrCategorias";
            this.Text = "GrCategorias";
            this.Load += new System.EventHandler(this.GrCategorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chValor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chValor;
        private System.Windows.Forms.DataVisualization.Charting.Chart chCantidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}