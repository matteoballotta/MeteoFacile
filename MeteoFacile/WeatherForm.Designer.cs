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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.ShownCityNameLabel = new System.Windows.Forms.Label();
            this.HighestTemperatureLabel = new System.Windows.Forms.Label();
            this.LowestTemperatureLabel = new System.Windows.Forms.Label();
            this.RainChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.WeatherChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.WindChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.HumidityChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.rangeToggleBtn = new System.Windows.Forms.Button();
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
            chartArea5.Name = "ChartArea1";
            this.RainChart.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.RainChart.Legends.Add(legend5);
            this.RainChart.Location = new System.Drawing.Point(0, 363);
            this.RainChart.Name = "RainChart";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            series6.Legend = "Legend1";
            series6.Name = "Pioggia";
            this.RainChart.Series.Add(series6);
            this.RainChart.Size = new System.Drawing.Size(465, 300);
            this.RainChart.TabIndex = 9;
            this.RainChart.Text = "chart1";
            // 
            // WeatherChart
            // 
            this.WeatherChart.BackColor = System.Drawing.Color.Transparent;
            this.WeatherChart.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            chartArea6.Name = "ChartArea1";
            this.WeatherChart.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.WeatherChart.Legends.Add(legend6);
            this.WeatherChart.Location = new System.Drawing.Point(12, 57);
            this.WeatherChart.Name = "WeatherChart";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Legend = "Legend1";
            series7.Name = "Temperatura";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Legend = "Legend1";
            series8.Name = "Visibilita";
            this.WeatherChart.Series.Add(series7);
            this.WeatherChart.Series.Add(series8);
            this.WeatherChart.Size = new System.Drawing.Size(1304, 300);
            this.WeatherChart.TabIndex = 7;
            this.WeatherChart.Text = "weatherChart";
            // 
            // WindChart
            // 
            this.WindChart.BackColor = System.Drawing.Color.Transparent;
            this.WindChart.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            chartArea7.Name = "ChartArea1";
            this.WindChart.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.WindChart.Legends.Add(legend7);
            this.WindChart.Location = new System.Drawing.Point(465, 363);
            this.WindChart.Name = "WindChart";
            this.WindChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            series9.Legend = "Legend1";
            series9.Name = "Velocità vento";
            this.WindChart.Series.Add(series9);
            this.WindChart.Size = new System.Drawing.Size(465, 300);
            this.WindChart.TabIndex = 13;
            this.WindChart.Text = "chart1";
            // 
            // HumidityChart
            // 
            this.HumidityChart.BackColor = System.Drawing.Color.Transparent;
            chartArea8.Name = "ChartArea1";
            this.HumidityChart.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.HumidityChart.Legends.Add(legend8);
            this.HumidityChart.Location = new System.Drawing.Point(921, 363);
            this.HumidityChart.Name = "HumidityChart";
            this.HumidityChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            series10.Legend = "Legend1";
            series10.Name = "Umidità";
            this.HumidityChart.Series.Add(series10);
            this.HumidityChart.Size = new System.Drawing.Size(465, 300);
            this.HumidityChart.TabIndex = 14;
            this.HumidityChart.Text = "chart1";
            // 
            // rangeToggleBtn
            // 
            this.rangeToggleBtn.Location = new System.Drawing.Point(1161, 113);
            this.rangeToggleBtn.Name = "rangeToggleBtn";
            this.rangeToggleBtn.Size = new System.Drawing.Size(116, 23);
            this.rangeToggleBtn.TabIndex = 15;
            this.rangeToggleBtn.Tag = "1";
            this.rangeToggleBtn.Text = "Meteo settimanale";
            this.rangeToggleBtn.UseVisualStyleBackColor = true;
            this.rangeToggleBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // WeatherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1380, 692);
            this.Controls.Add(this.rangeToggleBtn);
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
        private System.Windows.Forms.Button rangeToggleBtn;
    }
}