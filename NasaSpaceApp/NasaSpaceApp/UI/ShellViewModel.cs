using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
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

        public object MapPage => new MapPageView();

        public object RawDataPage => new RawDataView();

        public object LiveImagePage => new LiveImageVIew();

        public string Header { get; set; }

        public RelayCommand<PageType> OpenPageCommand { get; }
        public ShellViewModel()
        {
            m_navigationService = AppNavServiceManager.GetNavigationService();
            OpenPageCommand = new RelayCommand<PageType>(OpenPageAsync);
            CurrentPage = MapPage;
        }

        private void OpenPageAsync(PageType page)
        {
            switch (page)
            {
                case PageType.MapView:
                    CurrentPage = MapPage;
                    Header = "Map View";
                    break;
                case PageType.LiveImageView:
                    CurrentPage = LiveImagePage;
                    Header = "Live Image";
                    break;
                case PageType.RawView:
                    CurrentPage = RawDataPage;
                    Header = "Raw Data";
                    break;
            }
            RaisePropertyChanged(nameof(CurrentPage));
            RaisePropertyChanged(nameof(Header));
        }
    }
}
