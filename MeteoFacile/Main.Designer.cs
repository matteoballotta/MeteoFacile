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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.weatherChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cityInput = new System.Windows.Forms.TextBox();
            this.CitySearch = new System.Windows.Forms.Button();
            this.ShownDataCityName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rainChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.weatherChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rainChart)).BeginInit();
            this.SuspendLayout();
            // 
            // weatherChart
            // 
            this.weatherChart.BackColor = System.Drawing.Color.Transparent;
            this.weatherChart.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            chartArea3.Name = "ChartArea1";
            this.weatherChart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.weatherChart.Legends.Add(legend3);
            this.weatherChart.Location = new System.Drawing.Point(12, 78);
            this.weatherChart.Name = "weatherChart";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "Temperatura";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Legend = "Legend1";
            series5.Name = "Visibilita";
            this.weatherChart.Series.Add(series4);
            this.weatherChart.Series.Add(series5);
            this.weatherChart.Size = new System.Drawing.Size(1304, 300);
            this.weatherChart.TabIndex = 1;
            this.weatherChart.Text = "weatherChart";
            // 
            // cityInput
            // 
            this.cityInput.Location = new System.Drawing.Point(12, 39);
            this.cityInput.Name = "cityInput";
            this.cityInput.Size = new System.Drawing.Size(195, 20);
            this.cityInput.TabIndex = 2;
            // 
            // CitySearch
            // 
            this.CitySearch.Location = new System.Drawing.Point(213, 37);
            this.CitySearch.Name = "CitySearch";
            this.CitySearch.Size = new System.Drawing.Size(75, 23);
            this.CitySearch.TabIndex = 3;
            this.CitySearch.Text = "Cerca";
            this.CitySearch.UseVisualStyleBackColor = true;
            this.CitySearch.Click += new System.EventHandler(this.CitySearch_Click);
            // 
            // ShownDataCityName
            // 
            this.ShownDataCityName.AutoSize = true;
            this.ShownDataCityName.Location = new System.Drawing.Point(12, 62);
            this.ShownDataCityName.Name = "ShownDataCityName";
            this.ShownDataCityName.Size = new System.Drawing.Size(0, 13);
            this.ShownDataCityName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cerca località";
            // 
            // rainChart
            // 
            this.rainChart.BackColor = System.Drawing.Color.Transparent;
            this.rainChart.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            chartArea4.Name = "ChartArea1";
            this.rainChart.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.rainChart.Legends.Add(legend4);
            this.rainChart.Location = new System.Drawing.Point(15, 384);
            this.rainChart.Name = "rainChart";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            series6.Legend = "Legend1";
            series6.Name = "Pioggia";
            this.rainChart.Series.Add(series6);
            this.rainChart.Size = new System.Drawing.Size(1304, 300);
            this.rainChart.TabIndex = 6;
            this.rainChart.Text = "chart1";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1369, 707);
            this.Controls.Add(this.rainChart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ShownDataCityName);
            this.Controls.Add(this.CitySearch);
            this.Controls.Add(this.cityInput);
            this.Controls.Add(this.weatherChart);
            this.Name = "Main";
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.weatherChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rainChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart weatherChart;
        private System.Windows.Forms.TextBox cityInput;
        private System.Windows.Forms.Button CitySearch;
        private System.Windows.Forms.Label ShownDataCityName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart rainChart;
    }
}

