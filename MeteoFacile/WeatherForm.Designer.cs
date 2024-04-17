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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.ShownCityNameLabel = new System.Windows.Forms.Label();
            this.HighestTemperatureLabel = new System.Windows.Forms.Label();
            this.LowestTemperatureLabel = new System.Windows.Forms.Label();
            this.RainChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.WeatherChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.WindChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.HumidityChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.RainChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WeatherChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WindChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HumidityChart)).BeginInit();
            this.SuspendLayout();
            // 
            // ShownCityNameLabel
            // 
            this.ShownCityNameLabel.AutoSize = true;
            this.ShownCityNameLabel.Location = new System.Drawing.Point(12, 15);
            this.ShownCityNameLabel.Name = "ShownCityNameLabel";
            this.ShownCityNameLabel.Size = new System.Drawing.Size(95, 13);
            this.ShownCityNameLabel.TabIndex = 8;
            this.ShownCityNameLabel.Text = "Caricamento dati...";
            // 
            // HighestTemperatureLabel
            // 
            this.HighestTemperatureLabel.AutoSize = true;
            this.HighestTemperatureLabel.Location = new System.Drawing.Point(12, 28);
            this.HighestTemperatureLabel.Name = "HighestTemperatureLabel";
            this.HighestTemperatureLabel.Size = new System.Drawing.Size(0, 13);
            this.HighestTemperatureLabel.TabIndex = 11;
            // 
            // LowestTemperatureLabel
            // 
            this.LowestTemperatureLabel.AutoSize = true;
            this.LowestTemperatureLabel.Location = new System.Drawing.Point(12, 41);
            this.LowestTemperatureLabel.Name = "LowestTemperatureLabel";
            this.LowestTemperatureLabel.Size = new System.Drawing.Size(0, 13);
            this.LowestTemperatureLabel.TabIndex = 12;
            // 
            // RainChart
            // 
            this.RainChart.BackColor = System.Drawing.Color.Transparent;
            this.RainChart.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            chartArea1.Name = "ChartArea1";
            this.RainChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.RainChart.Legends.Add(legend1);
            this.RainChart.Location = new System.Drawing.Point(0, 363);
            this.RainChart.Name = "RainChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            series1.Legend = "Legend1";
            series1.Name = "Pioggia";
            this.RainChart.Series.Add(series1);
            this.RainChart.Size = new System.Drawing.Size(465, 300);
            this.RainChart.TabIndex = 9;
            this.RainChart.Text = "chart1";
            // 
            // WeatherChart
            // 
            this.WeatherChart.BackColor = System.Drawing.Color.Transparent;
            this.WeatherChart.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            chartArea2.Name = "ChartArea1";
            this.WeatherChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.WeatherChart.Legends.Add(legend2);
            this.WeatherChart.Location = new System.Drawing.Point(12, 57);
            this.WeatherChart.Name = "WeatherChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Temperatura";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Visibilita";
            this.WeatherChart.Series.Add(series2);
            this.WeatherChart.Series.Add(series3);
            this.WeatherChart.Size = new System.Drawing.Size(1304, 300);
            this.WeatherChart.TabIndex = 7;
            this.WeatherChart.Text = "weatherChart";
            // 
            // WindChart
            // 
            this.WindChart.BackColor = System.Drawing.Color.Transparent;
            this.WindChart.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            chartArea3.Name = "ChartArea1";
            this.WindChart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.WindChart.Legends.Add(legend3);
            this.WindChart.Location = new System.Drawing.Point(465, 363);
            this.WindChart.Name = "WindChart";
            this.WindChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            series4.Legend = "Legend1";
            series4.Name = "Velocità vento";
            this.WindChart.Series.Add(series4);
            this.WindChart.Size = new System.Drawing.Size(465, 300);
            this.WindChart.TabIndex = 13;
            this.WindChart.Text = "chart1";
            // 
            // HumidityChart
            // 
            this.HumidityChart.BackColor = System.Drawing.Color.Transparent;
            chartArea4.Name = "ChartArea1";
            this.HumidityChart.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.HumidityChart.Legends.Add(legend4);
            this.HumidityChart.Location = new System.Drawing.Point(921, 363);
            this.HumidityChart.Name = "HumidityChart";
            this.HumidityChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            series5.Legend = "Legend1";
            series5.Name = "Umidità";
            this.HumidityChart.Series.Add(series5);
            this.HumidityChart.Size = new System.Drawing.Size(465, 300);
            this.HumidityChart.TabIndex = 14;
            this.HumidityChart.Text = "chart1";
            // 
            // WeatherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1380, 692);
            this.Controls.Add(this.HumidityChart);
            this.Controls.Add(this.WindChart);
            this.Controls.Add(this.LowestTemperatureLabel);
            this.Controls.Add(this.HighestTemperatureLabel);
            this.Controls.Add(this.RainChart);
            this.Controls.Add(this.ShownCityNameLabel);
            this.Controls.Add(this.WeatherChart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "WeatherForm";
            this.Text = "Dati metereologici";
            ((System.ComponentModel.ISupportInitialize)(this.RainChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WeatherChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WindChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HumidityChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ShownCityNameLabel;
        private System.Windows.Forms.Label HighestTemperatureLabel;
        private System.Windows.Forms.Label LowestTemperatureLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart RainChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart WeatherChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart WindChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart HumidityChart;
    }
}