using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Maps;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Views;
using NasaSpaceApp.Helpers;

namespace NasaSpaceApp.UI
{
    public enum PageType
    {
        MapView,
        RawView,
        LiveImageView
    }
    public class ShellViewModel : ViewModelBase
    {
        private INavigationService m_navigationService;

        public object CurrentPage { get; set; }

        public string Header { get; set; }

        public RelayCommand<PageType> OpenPageCommand { get; }
        public ShellViewModel()
        {
            m_navigationService = AppNavServiceManager.GetNavigationService();
            OpenPageCommand = new RelayCommand<PageType>(OpenPageAsync);
            OpenPageAsync(PageType.MapView);
        }

        private void OpenPageAsync(PageType page)
        {
            switch (page)
            {
                case PageType.MapView:
                    CurrentPage = new MapPageView();
                    Header = "Map View";
                    break;
                case PageType.LiveImageView:
                    CurrentPage = new LiveImageVIew();
                    Header = "Live Image";
                    break;
                case PageType.RawView:
                    CurrentPage = new RawDataView();
                    Header = "Raw Data";
                    break;
            }
            RaisePropertyChanged(nameof(CurrentPage));
            RaisePropertyChanged(nameof(Header));
        }
    }
}
