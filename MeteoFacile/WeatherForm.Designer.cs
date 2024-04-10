namespace MeteoFacile
{
    partial class WeatherForm
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
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.ShownCityName = new System.Windows.Forms.Label();
            this.HighestTemperature = new System.Windows.Forms.Label();
            this.LowestTemperature = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rainChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.weatherChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.rainChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weatherChart)).BeginInit();
            this.SuspendLayout();
            // 
            // ShownCityName
            // 
            this.ShownCityName.AutoSize = true;
            this.ShownCityName.Location = new System.Drawing.Point(12, 15);
            this.ShownCityName.Name = "ShownCityName";
            this.ShownCityName.Size = new System.Drawing.Size(95, 13);
            this.ShownCityName.TabIndex = 8;
            this.ShownCityName.Text = "Caricamento dati...";
            // 
            // HighestTemperature
            // 
            this.HighestTemperature.AutoSize = true;
            this.HighestTemperature.Location = new System.Drawing.Point(12, 28);
            this.HighestTemperature.Name = "HighestTemperature";
            this.HighestTemperature.Size = new System.Drawing.Size(0, 13);
            this.HighestTemperature.TabIndex = 11;
            // 
            // LowestTemperature
            // 
            this.LowestTemperature.AutoSize = true;
            this.LowestTemperature.Location = new System.Drawing.Point(12, 41);
            this.LowestTemperature.Name = "LowestTemperature";
            this.LowestTemperature.Size = new System.Drawing.Size(0, 13);
            this.LowestTemperature.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(693, 323);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 10;
            // 
            // rainChart
            // 
            this.rainChart.BackColor = System.Drawing.Color.Transparent;
            this.rainChart.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            chartArea1.Name = "ChartArea1";
            this.rainChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.rainChart.Legends.Add(legend1);
            this.rainChart.Location = new System.Drawing.Point(15, 363);
            this.rainChart.Name = "rainChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            series1.Legend = "Legend1";
            series1.Name = "Pioggia";
            this.rainChart.Series.Add(series1);
            this.rainChart.Size = new System.Drawing.Size(1304, 300);
            this.rainChart.TabIndex = 9;
            this.rainChart.Text = "chart1";
            // 
            // weatherChart
            // 
            this.weatherChart.BackColor = System.Drawing.Color.Transparent;
            this.weatherChart.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            chartArea2.Name = "ChartArea1";
            this.weatherChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.weatherChart.Legends.Add(legend2);
            this.weatherChart.Location = new System.Drawing.Point(12, 57);
            this.weatherChart.Name = "weatherChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Temperatura";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Visibilita";
            this.weatherChart.Series.Add(series2);
            this.weatherChart.Series.Add(series3);
            this.weatherChart.Size = new System.Drawing.Size(1304, 300);
            this.weatherChart.TabIndex = 7;
            this.weatherChart.Text = "weatherChart";
            // 
            // WeatherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1380, 692);
            this.Controls.Add(this.LowestTemperature);
            this.Controls.Add(this.HighestTemperature);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rainChart);
            this.Controls.Add(this.ShownCityName);
            this.Controls.Add(this.weatherChart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "WeatherForm";
            this.Text = "Dati metereologici";
            ((System.ComponentModel.ISupportInitialize)(this.rainChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weatherChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ShownCityName;
        private System.Windows.Forms.Label HighestTemperature;
        private System.Windows.Forms.Label LowestTemperature;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart rainChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart weatherChart;
    }
}