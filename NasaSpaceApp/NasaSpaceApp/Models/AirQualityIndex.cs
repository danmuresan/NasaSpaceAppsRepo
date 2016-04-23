using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NasaSpaceApp.Models
{
    /*
     * {
          "country_name": "USA",
          "breezometer_aqi": 71,
          "breezometer_color": "#7FCD33",
          "breezometer_description": "Fair Air Quality",
          "country_aqi": 36,
          "country_aqi_prefix": "",
          "country_color": "#00E400",
          "country_description": "Good Air Quality",
          "data_valid": true,
          "key_valid": true,
          "random_recommendations": {
            "children": "No reason to panic, but pay attention to changes in air quality and any signals of breathing problems in your children",
            "sport": "Since we inhale more air during sports, you should keep track of changes in air quality for the next few hours",
            "health": "People with health sensitivities should monitor the air quality in the next few hours",
            "inside": "The air quality is still good - we'll keep you updated if things get worse",
            "outside": "You can go out, but please pay attention for changes in air quality"
          },
          "dominant_pollutant_canonical_name": "no2",
          "dominant_pollutant_description": "Nitrogen dioxide",
          "dominant_pollutant_text": {
            "main": "At the moment, nitrogen dioxide (NO2) are the main pollutant in the air.",
            "effects": "Exposure may cause increased bronchial reactivity in patients with asthma, lung function decline in patients with COPD and increased risk of respiratory infections, especially in young children.",
            "causes": "Main sources are fuel burning processes in industry and transportation."
          }
        }
*
***/

    public class AirQualityIndex
    {
        [JsonProperty("country_name")]
        public string CountryName { get; set; }

        [JsonProperty("breezometer_aqi")]
        public int? BreezometerAirQualityIndex { get; set; }

        [JsonProperty("breezometer_color")]
        public string BreezometerColor { get; set; }

        [JsonProperty("breezometer_description")]
        public string BreezometerDescription { get; set; }

        [JsonProperty("country_aqi")]
        public int? CountryAirQualityIndex { get; set; }

        [JsonProperty("country_aqi_prefix")]
        public string CountryAirQualityPrefix { get; set; }

        [JsonProperty("country_color")]
        public string CountryColor { get; set; }

        [JsonProperty("country_description")]
        public string CountryDescription { get; set; }

        [JsonProperty("data_valid")]
        public bool? DataValid { get; set; }

        [JsonProperty("key_valid")]
        public bool? KeyValid { get; set; }

        [JsonProperty("random_recommendations")]
        public Recommendations RandomRecommendations { get; set; }

        [JsonProperty("dominant_pollutant_canonical_name")]
        public string DominantPollutantCanonicalName { get; set; }

        [JsonProperty("dominant_pollutant_description")]
        public string DominantPollutantDescription { get; set; }

        [JsonProperty("dominant_pollutant_text")]
        public DominantPollutantText DominantPollutantText { get; set; }
    }

    public class Recommendations
    {
        [JsonProperty("children")]
        public string Children { get; set; }

        [JsonProperty("sport")]
        public string Sport { get; set; }

        [JsonProperty("health")]
        public string Health { get; set; }

        [JsonProperty("inside")]
        public string Inside { get; set; }

        [JsonProperty("outside")]
        public string Outside { get; set; }
    }

    public class DominantPollutantText
    {
        [JsonProperty("main")]
        public string Main { get; set; }

        [JsonProperty("effects")]
        public string Effects { get; set; }

        [JsonProperty("causes")]
        public string Causes { get; set; }
    }
}
