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
    public partial class Registro : ContentPage
    {
        public Registro()
        {
            InitializeComponent();
        }
        private async void RegistroCompleto(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(a.Text) && !string.IsNullOrEmpty(b.Text) && !string.IsNullOrEmpty(c.Text))
            {

                DisplayAlert("Registro Completo", "Bienvenido", "ok");
                await Shell.Current.GoToAsync("//Login");
            }

            else
            {
                DisplayAlert("Datos erróneos", "por favor llenar todos los campos", "OK");
            }
        }
    }
}