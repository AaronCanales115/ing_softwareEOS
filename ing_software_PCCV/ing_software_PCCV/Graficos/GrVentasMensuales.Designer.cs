namespace ing_software_PCCV.Graficos
{
    partial class GrVentasMensuales
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
            this.chtGrafico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chtGrafico)).BeginInit();
            this.SuspendLayout();
            // 
            // chtGrafico
            // 
            chartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.Name = "ChartArea1";
            this.chtGrafico.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chtGrafico.Legends.Add(legend1);
            this.chtGrafico.Location = new System.Drawing.Point(-36, 72);
            this.chtGrafico.Name = "chtGrafico";
            this.chtGrafico.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Monto";
            this.chtGrafico.Series.Add(series1);
            this.chtGrafico.Size = new System.Drawing.Size(1044, 475);
            this.chtGrafico.TabIndex = 0;
            this.chtGrafico.Text = "chart1";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft MHei", 18F);
            this.label.Location = new System.Drawing.Point(391, 21);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(353, 32);
            this.label.TabIndex = 2;
            this.label.Text = "Total en valor de ventas por mes";
            // 
            // GrVentasMensuales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1017, 622);
            this.Controls.Add(this.label);
            this.Controls.Add(this.chtGrafico);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GrVentasMensuales";
            this.Text = "GrVentasMensuales";
            this.Load += new System.EventHandler(this.GrVentasMensuales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chtGrafico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chtGrafico;
        private System.Windows.Forms.Label label;
    }
}