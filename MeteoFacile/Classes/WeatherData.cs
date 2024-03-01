using Newtonsoft.Json;
using System.Collections.Generic;

namespace MeteoFacile.Classes
{
    public class Hourly
    {
        [JsonProperty("time")]
        public List<string> Time { get; set; }

        [JsonProperty("temperature_2m")]
        public List<double> Temperature2m { get; set; }

        [JsonProperty("rain")]
        public List<double> Rain { get; set; }

        [JsonProperty("visibility")]
        public List<double> Visibility { get; set; }
    }

    public class HourlyUnits
    {
        [JsonProperty("time")]
        public string Time { get; set; }

        [JsonProperty("temperature_2m")]
        public string Temperature2m { get; set; }

        [JsonProperty("rain")]
        public string Rain { get; set; }

        [JsonProperty("visibility")]
        public string Visibility { get; set; }
    }

    public class WeatherData
    {
        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("generationtime_ms")]
        public double GenerationtimeMs { get; set; }

        [JsonProperty("utc_offset_seconds")]
        public int UtcOffsetSeconds { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("timezone_abbreviation")]
        public string TimezoneAbbreviation { get; set; }

        [JsonProperty("elevation")]
        public double Elevation { get; set; }

        [JsonProperty("hourly_units")]
        public HourlyUnits HourlyUnits { get; set; }

        [JsonProperty("hourly")]
        public Hourly Hourly { get; set; }
    }
}
