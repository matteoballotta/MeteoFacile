using MeteoFacile.Classes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms.VisualStyles;

namespace MeteoFacile
{
    public partial class WeatherForm : Form
    {
        private WeatherData weatherData;
        private List<String> availableDates;
        private string lastDate;

        public WeatherForm(City city)
        {
            InitializeComponent();
            rangeToggleBtn.Tag = true;
            lastDate = null;
            WeatherUpdate(city.DisplayName, double.Parse(city.Lat), double.Parse(city.Lon));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((bool)rangeToggleBtn.Tag)
            {
                lastDate = (string)DateCmbBox.SelectedItem;
                rangeToggleBtn.Text = "Meteo di oggi";
                SetWeatherRange();
            }
            else
            {
                rangeToggleBtn.Text = "Meteo settimanale";
                SetWeatherRange(lastDate == null ? DateTime.Today.ToString("yyyy-MM-dd") : lastDate);
            }
            rangeToggleBtn.Tag = !(bool)rangeToggleBtn.Tag;
        }

        private async void WeatherUpdate(string displayName, double latitude, double longitude)
        {
            ShownCityNameLabel.Text = displayName;

            // Ottenimento dati geografici
            string url = $"https://api.open-meteo.com/v1/forecast?latitude={latitude}&longitude={longitude}&hourly=temperature_2m,rain,visibility,wind_speed_10m,relative_humidity_2m";
            (System.Net.HttpStatusCode StatusCode, string Response) = await HttpRequest.Get(url);
            weatherData = JsonConvert.DeserializeObject<WeatherData>(Response);
            if (StatusCode != System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show("Errore", "Errore durante il caricamento dei dati del meteo!");
                return;
            }

            SetWeatherRange(DateTime.Today.ToString("yyyy-MM-dd"));

            // Inserimento dati di massima e minima temperatura misurata
            double highestTemperature = weatherData.Hourly.Temperature2m.Max();
            int highestTemperatureIdx = weatherData.Hourly.Temperature2m.IndexOf(highestTemperature);
            string highestTemperatureTime = weatherData.Hourly.Time[highestTemperatureIdx];

            double lowestTemperature = weatherData.Hourly.Temperature2m.Min();
            int lowestTemperatureIdx = weatherData.Hourly.Temperature2m.IndexOf(lowestTemperature);
            string lowestTemperatureTime = weatherData.Hourly.Time[lowestTemperatureIdx];

            LowestTemperatureLabel.Text = $"La temperatura più alta ({highestTemperature}° C) è stata registrata alle {highestTemperatureTime}.";
            HighestTemperatureLabel.Text = $"La temperatura più bassa ({lowestTemperature}° C) è stata registrata alle {lowestTemperatureTime}.";

            SetComboBoxContent();
            SendWeatherNotifications();

        }

        private void SetComboBoxContent()
        {
            availableDates = new List<String>();
            availableDates = weatherData.Hourly.Time.Select(date => date.Substring(0, 10)).Distinct().ToList();
            DateCmbBox.DataSource = availableDates;
        }

        private void SendWeatherNotifications () {
            if (weatherData != null && weatherData.Hourly != null) {
                string content = "Nessun evento atmosferico estremo segnalato";
                string imageUri = "Resources\\weatherIcon.png";

                if (weatherData.Hourly.Temperature2m.Any (temperature => temperature > 40 || temperature < 0))
                {
                    content = "È prevista una temperatura fuori dal normale in gionrnata!";
                    imageUri = "Resources\\temperature_estreme.jpg";
                }
                
                else if (weatherData.Hourly.Rain.Any (rain => rain > 20))
                {
                    content = "Potrebbe piovere!";
                    imageUri = "Resources\\pioggia.jpg";
                }
           
                else if (weatherData.Hourly.WindSpeed10m.Any(windSpeed => windSpeed > 30))
                {
                    content = "Presta attenzione, oggi il vento assumerà velocità estreme!";
                    imageUri = "Resources\\vento.jpg";
                }
                
                NotificationManager.ShowToastNotification("Notifica", content, imageUri);
            }
        }

        private void SetWeatherRange(string date = null)
        {
            // Ottenimento delle serie dei grafici
            Series temperatureSeries = WeatherChart.Series["Temperatura"];
            temperatureSeries.Points.Clear();

            Series visibilitySeries = WeatherChart.Series["Visibilita"];
            visibilitySeries.Points.Clear();

            Series rainSeries = RainChart.Series["Pioggia"];
            rainSeries.Points.Clear();

            Series windSeries = WindChart.Series["Velocità vento"];
            windSeries.Points.Clear();

            Series humiditySeries = HumidityChart.Series["Umidità"];
            humiditySeries.Points.Clear();


            int startIdx = date != null ? weatherData.Hourly.Time.FindIndex(x => x.Contains(date)) : 0;
            int endIdx = date != null ? startIdx + 23 : weatherData.Hourly.Time.Count;

            // Aggiunta dei dati ai grafici
            for (int i = startIdx; i < endIdx; i++)
            {
                temperatureSeries.Points.AddXY(weatherData.Hourly.Time.ElementAt(i), weatherData.Hourly.Temperature2m.ElementAt(i));
                rainSeries.Points.AddXY(weatherData.Hourly.Time.ElementAt(i), weatherData.Hourly.Rain.ElementAt(i));
                windSeries.Points.AddXY(weatherData.Hourly.Time.ElementAt(i), weatherData.Hourly.WindSpeed10m.ElementAt(i));
                humiditySeries.Points.AddXY(weatherData.Hourly.Time.ElementAt(i), weatherData.Hourly.RelativeHumidity2m.ElementAt(i));
                //visibilitySeries.Points.AddY(weatherData.Hourly.Visibility.ElementAt(i));
            }
        }

        private void DateCmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetWeatherRange((string)DateCmbBox.SelectedItem);
        }
    }
}
