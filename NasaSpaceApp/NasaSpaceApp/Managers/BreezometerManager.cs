using NasaSpaceApp.Helpers;
using NasaSpaceApp.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace NasaSpaceApp.Managers
{
    public class BreezometerManager
    {
        private readonly HttpClient m_httpClient;

        public BreezometerManager()
        {
            m_httpClient = new HttpClient();
        }

        public async Task<AirQualityIndex> GetBreezometerAirQualityIndexAsync(double latitude, double longitude)
        {
            string url = string.Format(HttpClientUtil.AqiUrl, latitude, longitude);
            var uri = new Uri(HttpClientUtil.BaseBreezometerApi + url);

            try
            {
                var response = await m_httpClient.GetAsync(uri);
                if (response != null)
                {
                    var content = await response.Content.ReadAsAsync<AirQualityIndex>();
                    return content;
                }
            }
            catch (Exception ex)
            {
                //Console.WriteLine(ex.Message);

                return null;
            }

            return null;
        }

        public async Task<List<AirQualityIndex>> GetBreezometerAirQualityIndexHistoricalListAsync(DateTime rangeStart, DateTime rangeEnd, double latitude, double longitude)
        {
            string url = string.Format(HttpClientUtil.HistoricalAqiUrl, rangeStart, rangeEnd, latitude, longitude);
            var uri = new Uri(HttpClientUtil.BaseBreezometerApi + url);

            try
            {
                var response = await m_httpClient.GetAsync(uri);
                if (response != null)
                {
                    var content = await response.Content.ReadAsAsync<List<AirQualityIndex>>();
                    return content;
                }
            }
            catch (Exception ex)
            {
                //Console.WriteLine(ex.Message);

                return null;
            }

            return null;
        }

    }
}
