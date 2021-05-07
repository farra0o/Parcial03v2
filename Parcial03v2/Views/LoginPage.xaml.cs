using Parcial03v2.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Parcial03v2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }



        private async void SignUp_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//Login/Registro");
        }

        private async void Forgot_pass(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//Login/forget");
        }

        private async void Ingresar(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(a.Text) && !string.IsNullOrEmpty(b.Text))
            {

                DisplayAlert("Bienvenido", "Gracias por utilizarnos", "ok");
                await Shell.Current.GoToAsync("//main");
            }

            else
            {
                DisplayAlert("Datos erróneos", "por favor llenar todos los campos", "OK");
            }
        }
    }
}