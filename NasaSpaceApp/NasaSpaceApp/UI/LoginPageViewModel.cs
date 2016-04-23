using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.UI.Xaml.Controls;

namespace NasaSpaceApp.UI
{
    public class LoginPageViewModel : ViewModelBase
    {
        private readonly HttpClient m_httpClient;
        public RelayCommand<object> LoginCommand { get; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public LoginPageViewModel()
        {
            m_httpClient = new HttpClient();
            LoginCommand = new RelayCommand<object>(LoginAsync);
        }

        private void LoginAsync(object passwordBox)
        {
            Password = (passwordBox as PasswordBox).Password;
        }
    }
}
