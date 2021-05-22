using SiluetaYa.ViewModels;
using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace SiluetaYa.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ItemsPage());
        }
    }
}