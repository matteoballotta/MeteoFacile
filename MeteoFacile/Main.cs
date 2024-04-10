using System.Windows.Forms;
using MeteoFacile.Classes;
using Newtonsoft.Json;
using System.Linq;
using System.Collections.Generic;

namespace MeteoFacile
{
    public partial class MenuForm : Form
    {

        public MenuForm()
        {
            InitializeComponent();
        }

        private async void CitySearch_Click(object sender, System.EventArgs e)
        {
            // Ottenimento risultati operazione di Geocoding
            const string KEY = "6616a0658d0bd896308578ohi7b00a6";
            string url = $"https://geocode.maps.co/search?q={CityInput.Text}&api_key={KEY}";
            (System.Net.HttpStatusCode StatusCode, string Response) = await HttpRequest.Get(url);

            // Controlli sulla validità dei dati per non aprire una nuova Form in caso di errore
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

            // Apertura della Form passando i dati della città richiesta
            City city = JsonConvert.DeserializeObject<List<City>>(Response).First();
            WeatherForm wf = new WeatherForm(city);
            wf.Show();
        }
    }
}
