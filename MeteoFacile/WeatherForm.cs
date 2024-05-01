using MeteoFacile.Classes;
using Newtonsoft.Json;
using System;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MeteoFacile
{
    public partial class WeatherForm : Form
    {
        private WeatherData weatherData;

        public WeatherForm(City city)
        {
            InitializeComponent();
            rangeToggleBtn.Tag = true;
            WeatherUpdate(city.DisplayName, double.Parse(city.Lat), double.Parse(city.Lon));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if((bool)rangeToggleBtn.Tag)
            {
                rangeToggleBtn.Text = "Meteo di oggi";
                setWeatherRange();
            }
            else
            {
                rangeToggleBtn.Text = "Meteo settimanale";
                setWeatherRange(DateTime.Today.ToString("yyyy-MM-dd"));
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

            setWeatherRange(DateTime.Today.ToString("yyyy-MM-dd"));

            // Inserimento dati di massima e minima temperatura misurata
            double highestTemperature = weatherData.Hourly.Temperature2m.Max();
            int highestTemperatureIdx = weatherData.Hourly.Temperature2m.IndexOf(highestTemperature);
            string highestTemperatureTime = weatherData.Hourly.Time[highestTemperatureIdx];

            double lowestTemperature = weatherData.Hourly.Temperature2m.Min();
            int lowestTemperatureIdx = weatherData.Hourly.Temperature2m.IndexOf(lowestTemperature);
            string lowestTemperatureTime = weatherData.Hourly.Time[lowestTemperatureIdx];

            LowestTemperatureLabel.Text = $"La temperatura più alta ({highestTemperature}° C) è stata registrata alle {highestTemperatureTime}.";
            HighestTemperatureLabel.Text = $"La temperatura più bassa ({lowestTemperature}° C) è stata registrata alle {lowestTemperatureTime}.";

            SendWeatherNotifications();
        
        }

        private void SendWeatherNotifications () {
            if (weatherData != null && weatherData.Hourly != null) {
                string content = "Nessun evento atmosferico estremo segnalato";

                if (weatherData.Hourly.Temperature2m.Any (temperature => temperature > 40 || temperature < 0))
                    content = "È prevista una temperatura fuori dal normale in gionrnata!";
                else if (weatherData.Hourly.Rain.Any (rain => rain > 20) )
                    content = "Potrebbe piovere!";
                else if (weatherData.Hourly.WindSpeed10m.Any(windSpeed => windSpeed > 30))
                    content = "Presta attenzione, oggi il vento assumerà velocità estreme!";
                
                NotificationManager.ShowToastNotification("Notifica", content);
            }
        }

        private void setWeatherRange(string date = null)
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

    }
}
