using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight.Views;

namespace NasaSpaceApp.Helpers
{
    public class AppNavServiceManager
    {
        public static INavigationService NavigationService { get; private set; }
        public AppNavServiceManager(INavigationService navService)
        {
            NavigationService = navService;
        }

        public static INavigationService GetNavigationService()
        {
            return NavigationService;
        }
    }
}
