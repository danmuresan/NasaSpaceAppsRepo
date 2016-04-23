using System;

namespace NasaSpaceApp.Helpers
{
    public class HttpClientUtil
    {
        public static string BaseUrl = "http://nasadbapi.azurewebsites.net/";
        public static string LoginUrl = "api/Login";
        public static string CreateAccountUrl = "api/Users";

        public const string BreezometerKey = "faeaed1f594c4bb0b88c90782a0e9754";
        public const string BaseBreezometerApi = "https://api.breezometer.com/";
        public const string AqiUrl = "baqi/?lat={0}&lon={1}&key=" + BreezometerKey;
        public const string AqiLocationUrl = "baqi/?location={0}&key=" + BreezometerKey;
        public const string HistoricalAqiUrl = "baqi/?start_datetime={0}&end_datetime={1}&lat={2}&lon={3}&key=" + BreezometerKey;

        public static Uri GetUriForUrl(string url)
        {
            return new Uri(BaseUrl + url);
        }
    }
}