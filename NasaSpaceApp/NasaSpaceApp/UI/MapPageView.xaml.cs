using NasaSpaceApp.Managers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Services.Maps;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Maps;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using NasaSpaceApp.Helpers;
using NasaSpaceApp.Managers;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace NasaSpaceApp.UI
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MapPageView : Page
    {
        private BreezometerManager m_aqiManager;

        private List<string> SuggestedCities { get; } = new List<string>
        {
            "Cluj-Napoca",
            "Paris",
            "Stockholm",
            "Moscow",
            "Oslo",
            "London",
            "Wien",
            "Washington",
            "Prague",
            "Beijing",
            "Berlin",
            "Mumbai",
            "Sankt Petersburg",
            "Tokyo",
            "Barcelona",
            "Madrid",
            "Instabul",
            "New York"
        };

        public MapPageView()
        {
            this.InitializeComponent();
            MapControl.ColorScheme = MapColorScheme.Dark;
            MapControl.Style = MapStyle.Aerial3DWithRoads;
            SuggestedCities.OrderBy(x => x);
            m_aqiManager = new BreezometerManager();
        }

        private void AutoSuggestBox_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
        {
            List<string> myList = new List<string>();
            foreach (string city in SuggestedCities)
            {
                if (city.ToLower().Contains(sender.Text.ToLower()))
                {
                    myList.Add(city);
                }
            }

            sender.ItemsSource = myList;
        }

        private async void AutoSuggestBox_QuerySubmitted(AutoSuggestBox sender, AutoSuggestBoxQuerySubmittedEventArgs args)
        {
            string city = sender.Text;
            MapLocationFinderResult result = await MapLocationFinder.FindLocationsAsync(city, new Geopoint(new BasicGeoposition()));
            var location = result.Locations.FirstOrDefault();

            if (location != null)
            {
                var pos = location.Point.Position;
                var data = m_aqiManager.GetBreezometerAirQualityIndexAsync(pos.Latitude, pos.Longitude);
            }
        }

        private async void MapPageView_OnLoaded(object sender, RoutedEventArgs e)
        {
              BreezometerManager manager = new BreezometerManager();

            try
            {
                var data = await manager.GetBreezometerAirQualityIndexAsync(40.7324296, -73.9977264);
            }
            catch (Exception ex)
            {
                
            }
        }
    }
}
