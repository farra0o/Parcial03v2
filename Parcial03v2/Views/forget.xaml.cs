﻿using System;
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
            DisplayAlert("Registro", "Haz confirmado tu registro", "ok");


            await Shell.Current.GoToAsync("//Login");

        }
    }
}