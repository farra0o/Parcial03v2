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
    public partial class ModificarPerfil : ContentPage
    {
        public ModificarPerfil()
        {
            InitializeComponent();
        }

        private async void cambios(object sender, EventArgs e)
        {

            DisplayAlert("Configuraciones", "Cambios Guardados", "ok");


            await Shell.Current.GoToAsync("//main");


        }
    }
}