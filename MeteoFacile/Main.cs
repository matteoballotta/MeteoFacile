using System.Windows.Forms;
using MeteoFacile.Classes;
using Newtonsoft.Json;
using System.Linq;
using System.Collections.Generic;

namespace MeteoFacile
{
    public partial class Main : Form
    {

        public Main()
        {
            InitializeComponent();
        }

        private async void CitySearch_Click(object sender, System.EventArgs e)
        {
            const string key = "6616a0658d0bd896308578ohi7b00a6";
            string url = $"https://geocode.maps.co/search?q={cityInput.Text}&api_key={key}";
            (System.Net.HttpStatusCode StatusCode, string Response) = await HttpRequest.Get(url);
            if (StatusCode != System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show("Errore durante la ricerca della località!", "Errore");
                return;
            }
            if (JsonConvert.DeserializeObject<List<City>>(Response).Count == 0)
            {
                MessageBox.Show("Località non disponibile!", "Errore");
                return;
            }
            City city = JsonConvert.DeserializeObject<List<City>>(Response).First();

            WeatherForm wf = new WeatherForm(city);
            wf.Show();
        }
    }
}
