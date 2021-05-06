using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Parcial03v2.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));
            RestartCommand = new Command(() =>
            {
                Shell.Current.GoToAsync("//login");
            });

            LogoutCommand = new Command(() =>
            {
                Shell.Current.GoToAsync("//login");
            });

        }

        public ICommand OpenWebCommand { get; }

        public ICommand RestartCommand { get; }

        public ICommand LogoutCommand { get; }

        public ICommand BackCommand { get; }
    }
}
