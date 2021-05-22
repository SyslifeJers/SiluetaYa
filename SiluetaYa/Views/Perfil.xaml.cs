using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using SiluetaYa.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SiluetaYa.Views
{
    public partial class Perfil : ContentPage
    {
        public Perfil()
        {
            InitializeComponent();
            BindingContext = new AboutViewModel();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            MessagingCenter.Send<object>(this, App.EVENT_LAUNCH_MAIN_PAGE);
        }
        private void Button_Clicked2(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ItemsPage());
        }
    }
}