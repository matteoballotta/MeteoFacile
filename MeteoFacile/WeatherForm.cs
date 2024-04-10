using MeteoFacile.Classes;
using Newtonsoft.Json;
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
            WeatherUpdate(city.DisplayName, double.Parse(city.Lat), double.Parse(city.Lon));
        }

        private async void WeatherUpdate(string displayName, double latitude, double longitude)
        {
            ShownCityNameLabel.Text = displayName;

            // Ottenimento dati geografici
            string url = $"https://api.open-meteo.com/v1/forecast?latitude={latitude}&longitude={longitude}&hourly=temperature_2m,rain,visibility,wind_speed_10m";
            (System.Net.HttpStatusCode StatusCode, string Response) = await HttpRequest.Get(url);
            weatherData = JsonConvert.DeserializeObject<WeatherData>(Response);
            if (StatusCode != System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show("Errore", "Errore durante il caricamento dei dati del meteo!");
                return;
            }

            // Ottenimento delle serie dei grafici
            Series temperatureSeries = WeatherChart.Series["Temperatura"];
            temperatureSeries.Points.Clear();

            Series visibilitySeries = WeatherChart.Series["Visibilita"];
            visibilitySeries.Points.Clear();

            Series rainSeries = RainChart.Series["Pioggia"];
            rainSeries.Points.Clear();

            Series windSeries = WindChart.Series["Velocità vento"];
            windSeries.Points.Clear();

            // Aggiunta dei dati ai grafici
            for (int i = 0; i < weatherData.Hourly.Time.Count; i++)
            {
                temperatureSeries.Points.AddXY(weatherData.Hourly.Time.ElementAt(i), weatherData.Hourly.Temperature2m.ElementAt(i));
                rainSeries.Points.AddXY(weatherData.Hourly.Time.ElementAt(i), weatherData.Hourly.Rain.ElementAt(i));
                windSeries.Points.AddXY(weatherData.Hourly.Time.ElementAt(i), weatherData.Hourly.WindSpeed10m.ElementAt(i));
                //visibilitySeries.Points.AddY(weatherData.Hourly.Visibility.ElementAt(i));
            }

            // Inserimento dati di massima e minima temperatura misurata
            double highestTemperature = weatherData.Hourly.Temperature2m.Max();
            int highestTemperatureIdx = weatherData.Hourly.Temperature2m.IndexOf(highestTemperature);
            string highestTemperatureTime = weatherData.Hourly.Time[highestTemperatureIdx];

            double lowestTemperature = weatherData.Hourly.Temperature2m.Min();
            int lowestTemperatureIdx = weatherData.Hourly.Temperature2m.IndexOf(lowestTemperature);
            string lowestTemperatureTime = weatherData.Hourly.Time[lowestTemperatureIdx];

            LowestTemperatureLabel.Text = $"La temperatura più alta ({highestTemperature}° C) è stata registrata alle {highestTemperatureTime}.";
            HighestTemperatureLabel.Text = $"La temperatura più bassa ({lowestTemperature}° C) è stata registrata alle {lowestTemperatureTime}.";

            CheckWeather(latitude, longitude);
        
        }

        private void CheckWeather (var latitudine, var longitudine) {
            if (weatherData != null && weatherData.Hourly != null) {
                if (weatherData.Hourly.Temperature2m.Any (temperature => temperature > 40 || temperature < -10)) { ShowToastNotification ("Evento Atmosferico Estremo", "Temperature estreme segnalate!"); }
                else if (weatherData.Hourly.Rain.Any (rain => rain > 20) ) { ShowToastNotification ("Evento Atmosferico Estremo", "Forte pioggia segnalata!"); }
                else if (weatherData.Hourly.PrecipitationIntensity.Any(precipitation => precipitation > 0.7)) { ShowToastNotification("Evento Atmosferico Estremo", "Forte temporale in arrivo!"); }
                else if (weatherData.Hourly.SnowfallDepth.Any(snowfall => snowfall > 10)) { ShowToastNotification("Evento Atmosferico Estremo", "Nevicata intensa segnalata!"); }
                else if (weatherData.Hourly.WindSpeed.Any(windSpeed => windSpeed > 30)) { ShowToastNotification("Evento Atmosferico Estremo", "Forte vento in arrivo!"); }
            }
        }
    }
}
