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
    public partial class forget : ContentPage
    {
        public forget()
        {
            InitializeComponent();
        }

        private async void Envio(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(a.Text) )
            {

                DisplayAlert("Correo enviado", "revisar correo y cambiar contraseña", "ok");
                await Shell.Current.GoToAsync("//Login");
            }

            else
            {
                DisplayAlert("Correo invalido", "por favor llenar todos los campos correctamente", "OK");
            }


        }
    }
}