using System.Windows.Forms;
using MeteoFacile.Classes;
using Newtonsoft.Json;
using System.Linq;
using System.Collections.Generic;

namespace MeteoFacile
{
    public partial class Main : Form
    {
        private WeatherData weatherData;

        public Main()
        {
            InitializeComponent();
            WeatherUpdate(44.4938, 11.3387);
        }

        private async void WeatherUpdate(double latitude, double longitude)
        {
            string url = $"https://api.open-meteo.com/v1/forecast?latitude={latitude}&longitude={longitude}&hourly=temperature_2m,rain,visibility";
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

            for (int i = 0; i < weatherData.Hourly.Time.Count; i++)
            {
                temperatureSeries.Points.AddXY(weatherData.Hourly.Time.ElementAt(i), weatherData.Hourly.Temperature2m.ElementAt(i));
                //visibilitySeries.Points.AddY(weatherData.Hourly.Visibility.ElementAt(i));
            }

	    double highestTemperature = weatherData.Hourly.Temperature2m.Max();
            int indexHighestTemperature = weatherData.Hourly.Temperature2m.IndexOf(highestTemperature);
            var timeOfHighestTemperature = weatherData.Hourly.Time[indexHighestTemperature];

            double lowestTemperature = weatherData.Hourly.Temperature2m.Min();
            int indexLowestTemperature = weatherData.Hourly.Temperature2m.IndexOf(lowestTemperature); 
            var timeOfLowestTemperature = weatherData.Hourly.Time[indexLowestTemperature];

            MessageBox.Show($"La temperatura più alta ({highestTemperature}°C) è stata registrata alle {timeOfHighestTemperature}.", "Temperatura Massima");
            MessageBox.Show($"La temperatura più bassa ({lowestTemperature}°C) è stata registrata alle {timeOfLowestTemperature}.", "Temperatura Minima");
        }

        private async void citySearch_Click(object sender, System.EventArgs e)
        {
            string cityName = citySearch.Text;
            string url = "https://nominatim.openstreetmap.org/search.php?format=jsonv2&q=london";
            (System.Net.HttpStatusCode StatusCode, string Response) = await HttpRequest.Get(url);
            List<City> myDeserializedClass = JsonConvert.DeserializeObject<List<City>>(Response);
        }
    }
}
