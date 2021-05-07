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
    public partial class AgregarSerie : ContentPage
    {
        public AgregarSerie()
        {
            InitializeComponent();
        }

        private async void cambios(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(a.Text) && !string.IsNullOrEmpty(b.Text) && !string.IsNullOrEmpty(c.Text) && !string.IsNullOrEmpty(d.Text) )
            {
              
                DisplayAlert("Configuraciones", "Cambios Guardados", "ok");
                await Shell.Current.GoToAsync("//main");
            }

            else
            {
                DisplayAlert("Datos erróneos", "por favor llenar todos los campos", "OK");
            }
            


        }
    }
}