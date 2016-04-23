using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace NasaSpaceApp.Helpers
{
    public class AppDataUtil
    {
        public static string KeyUserInfoContainer = "UserInfo";

        public static string KeyUsername = "Username";

        public static string KeyMd5Password = "Password";
        
        public static void SaveValue(string key, string value)
        {
            var container = ApplicationData.Current.LocalSettings;
            container.Values[key] = value;
        }

        public static string LoadValue(string key)
        {
            var container = ApplicationData.Current.LocalSettings;
            var returnValue = container.Values[key];
            return returnValue.ToString();
        }
    }
}
