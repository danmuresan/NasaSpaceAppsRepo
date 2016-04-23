using System;

namespace NasaSpaceApp.Helpers
{
    public class HttpClientUtil
    {
        public static string BaseUrl = "http://nasadbapi.azurewebsites.net/";
        public static string LoginUrl = "api/Login";

        public static Uri GetUriForUrl(string url)
        {
            return new Uri(BaseUrl + url);
        }
    }
}