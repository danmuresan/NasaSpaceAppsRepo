using System;

namespace NasaSpaceApp.Helpers
{
    public class HttpClientUtil
    {
        public static string BaseUrl = "http://nasadbapi.azure.com/";
        public static string LoginUrl = "";

        public static Uri GetUriForUrl(string url)
        {
            return new Uri(BaseUrl + url);
        }
    }
}