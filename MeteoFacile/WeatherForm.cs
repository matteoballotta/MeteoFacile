using MeteoFacile.Classes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeteoFacile
{
    public partial class WeatherForm : Form
    {
        private WeatherData weatherData;

        public WeatherForm(City city)
        {
            InitializeComponent();
            WeatherUpdate(city.DisplayName, double.Parse(city.Lat), double.Parse(city.Lon));
        }

        private async void WeatherUpdate(string displayName, double latitude, double longitude)
        {
            ShownCityName.Text = displayName;

            string url = $"https://api.open-meteo.com/v1/forecast?latitude={latitude}&longitude={longitude}&hourly=temperature_2m,rain,visibility,wind_speed_10m";
            (System.Net.HttpStatusCode StatusCode, string Response) = await HttpRequest.Get(url);
            weatherData = JsonConvert.DeserializeObject<WeatherData>(Response);
            if (StatusCode != System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show("Errore", "Errore durante il caricamento dei dati del meteo!");
                return;
            }

            var temperatureSeries = weatherChart.Series["Temperatura"];
            temperatureSeries.Points.Clear();

            var visibilitySeries = weatherChart.Series["Visibilita"];
            visibilitySeries.Points.Clear();

            var rainSeries = rainChart.Series["Pioggia"];
            rainSeries.Points.Clear();

            var windSeries = windChart.Series["Velocità vento"];
            windSeries.Points.Clear();

            for (int i = 0; i < weatherData.Hourly.Time.Count; i++)
            {
                temperatureSeries.Points.AddXY(weatherData.Hourly.Time.ElementAt(i), weatherData.Hourly.Temperature2m.ElementAt(i));
                //visibilitySeries.Points.AddY(weatherData.Hourly.Visibility.ElementAt(i));
                rainSeries.Points.AddXY(weatherData.Hourly.Time.ElementAt(i), weatherData.Hourly.Rain.ElementAt(i));
                windSeries.Points.AddXY(weatherData.Hourly.Time.ElementAt(i), weatherData.Hourly.WindSpeed10m.ElementAt(i));
            }

            double highestTemperature = weatherData.Hourly.Temperature2m.Max();
            int indexHighestTemperature = weatherData.Hourly.Temperature2m.IndexOf(highestTemperature);
            var timeOfHighestTemperature = weatherData.Hourly.Time[indexHighestTemperature];

            double lowestTemperature = weatherData.Hourly.Temperature2m.Min();
            int indexLowestTemperature = weatherData.Hourly.Temperature2m.IndexOf(lowestTemperature);
            var timeOfLowestTemperature = weatherData.Hourly.Time[indexLowestTemperature];

            LowestTemperature.Text = $"La temperatura più alta ({highestTemperature}°C) è stata registrata alle {timeOfHighestTemperature}.";
            HighestTemperature.Text = $"La temperatura più bassa ({lowestTemperature}°C) è stata registrata alle {timeOfLowestTemperature}.";
        }
    }
}
