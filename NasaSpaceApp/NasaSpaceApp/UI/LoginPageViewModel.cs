using System;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using NasaSpaceApp.Helpers;
using NasaSpaceApp.Models;
using System.Net.Http;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using GalaSoft.MvvmLight.Views;

namespace NasaSpaceApp.UI
{
    public class LoginPageViewModel : ViewModelBase
    {
        private readonly HttpClient m_httpClient;
        private readonly INavigationService m_navigationService;

        private bool m_loginFailed;
        public RelayCommand<object> LoginCommand { get; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public Visibility ErrorVisibility => LoginFailed ? Visibility.Visible : Visibility.Collapsed;

        public bool LoginFailed
        {
            get { return m_loginFailed; }
            set
            {
                Set(nameof(LoginFailed), ref m_loginFailed, value);
                RaisePropertyChanged(nameof(ErrorVisibility));
            }
        }

        public LoginPageViewModel()
        {
            m_httpClient = new HttpClient();
            LoginCommand = new RelayCommand<object>(LoginAsync);
            LoginFailed = false;
            m_navigationService = AppNavServiceManager.GetNavigationService();
        }

        private async void LoginAsync(object passwordBox)
        {
            Password = (passwordBox as PasswordBox).Password;
            
            LoginModel model = new LoginModel
            {
                Username = UserName,
                Password = Password
            };
            try
            {
                var response =
                    await
                        m_httpClient.PostAsJsonAsync<LoginModel>(HttpClientUtil.GetUriForUrl(HttpClientUtil.LoginUrl),
                            model);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    if (content == bool.FalseString.ToLowerInvariant())
                    {
                        throw new ArgumentException("Login Failed");
                    }
                    LoginFailed = false;
                    AppDataUtil.SaveValue(AppDataUtil.KeyUsername, UserName);
                    AppDataUtil.SaveValue(AppDataUtil.KeyMd5Password, Password);
                    m_navigationService.NavigateTo(nameof(ShellVIew));
                }
                else
                {
                    LoginFailed = true;
                }
            }
            catch (Exception ex)
            {
                LoginFailed = true;
            }
        }
    }
}
