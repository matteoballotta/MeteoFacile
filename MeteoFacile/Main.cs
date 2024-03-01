using MeteoFacile.Classes;
using Newtonsoft.Json;
using System.Linq;
using System.Windows.Forms;

namespace MeteoFacile
{
    public partial class Main : Form
    {
        private WeatherData weatherData;

        public Main()
        {
            InitializeComponent();
            OnMainLoad();
        }

        private async void OnMainLoad()
        {
            string url = "https://api.open-meteo.com/v1/forecast?latitude=44.4938&longitude=11.3387&hourly=temperature_2m,rain,visibility";
            (System.Net.HttpStatusCode StatusCode, string Response) tuple = await HttpRequest.Get(url);
            weatherData = JsonConvert.DeserializeObject<WeatherData>(tuple.Response);
            if (tuple.StatusCode != System.Net.HttpStatusCode.OK)
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
        }
    }
}
