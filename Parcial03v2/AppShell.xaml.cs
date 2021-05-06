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
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//Login");
        }
    }
}
