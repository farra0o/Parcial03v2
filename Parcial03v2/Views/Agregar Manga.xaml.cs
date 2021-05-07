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
    public partial class Agregar_Manga : ContentPage
    {
        public Agregar_Manga()
        {
            InitializeComponent();
        }

        private async void cambios(object sender, EventArgs e)
        {
        }
    }
}