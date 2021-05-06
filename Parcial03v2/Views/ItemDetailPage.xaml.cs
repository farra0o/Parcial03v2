using Parcial03v2.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Parcial03v2.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}