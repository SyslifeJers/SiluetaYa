using SiluetaYa.ViewModels;
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
    }
}