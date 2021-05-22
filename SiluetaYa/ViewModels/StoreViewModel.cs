using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace SiluetaYa.ViewModels
{
    public class StoreViewModel : BaseViewModel
    {
        public StoreViewModel()
        {
            Title = "Store";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));
        }

        public ICommand OpenWebCommand { get; }
    }
}