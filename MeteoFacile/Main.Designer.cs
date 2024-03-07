namespace MeteoFacile
{
    partial class Main
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
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.weatherChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cityInput = new System.Windows.Forms.TextBox();
            this.citySearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.weatherChart)).BeginInit();
            this.SuspendLayout();
            // 
            // weatherChart
            // 
            chartArea1.Name = "ChartArea1";
            this.weatherChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.weatherChart.Legends.Add(legend1);
            this.weatherChart.Location = new System.Drawing.Point(28, 198);
            this.weatherChart.Name = "weatherChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Temperatura";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Visibilita";
            this.weatherChart.Series.Add(series1);
            this.weatherChart.Series.Add(series2);
            this.weatherChart.Size = new System.Drawing.Size(1304, 300);
            this.weatherChart.TabIndex = 1;
            this.weatherChart.Text = "weatherChart";
            // 
            // cityInput
            // 
            this.cityInput.Location = new System.Drawing.Point(12, 12);
            this.cityInput.Name = "cityInput";
            this.cityInput.Size = new System.Drawing.Size(195, 20);
            this.cityInput.TabIndex = 2;
            // 
            // citySearch
            // 
            this.citySearch.Location = new System.Drawing.Point(213, 10);
            this.citySearch.Name = "citySearch";
            this.citySearch.Size = new System.Drawing.Size(75, 23);
            this.citySearch.TabIndex = 3;
            this.citySearch.Text = "button1";
            this.citySearch.UseVisualStyleBackColor = true;
            this.citySearch.Click += new System.EventHandler(this.citySearch_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1369, 523);
            this.Controls.Add(this.citySearch);
            this.Controls.Add(this.cityInput);
            this.Controls.Add(this.weatherChart);
            this.Name = "Main";
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.weatherChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart weatherChart;
        private System.Windows.Forms.TextBox cityInput;
        private System.Windows.Forms.Button citySearch;
    }
}

