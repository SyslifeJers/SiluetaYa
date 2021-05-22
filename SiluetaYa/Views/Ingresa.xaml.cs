using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace SiluetaYa.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Ingresa : ContentPage
    {
        public Ingresa()
        {
            InitializeComponent();
        }
        private void Button(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Calendar());
        }
    }
}