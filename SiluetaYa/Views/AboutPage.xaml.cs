﻿using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SiluetaYa.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            MessagingCenter.Send<object>(this, App.EVENT_LAUNCH_MAIN_PAGE);
        }
        private void Button_Clicked2(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync("Page5");
        }
    }
}