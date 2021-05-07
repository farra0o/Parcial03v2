using Parcial03v2.ViewModels;
using Parcial03v2.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Parcial03v2
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
            Routing.RegisterRoute(nameof(Registro),  typeof(Registro));
            Routing.RegisterRoute(nameof(forget), typeof(forget));
            Routing.RegisterRoute(nameof(ConfiguracionesGenerales), typeof(ConfiguracionesGenerales));
            Routing.RegisterRoute(nameof(AgregarSerie), typeof(AgregarSerie));
            Routing.RegisterRoute(nameof(ModificarPerfil), typeof(ModificarPerfil));
            Routing.RegisterRoute(nameof(Agregar_Manga), typeof(Agregar_Manga));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//Login");

        }
    }
}
