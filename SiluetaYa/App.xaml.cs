using SiluetaYa.Services;
using SiluetaYa.Views;
using SiluetaYa.Views.PrimeraFase;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SiluetaYa
{
    public partial class App : Application
    {
        public static string EVENT_LAUNCH_LOGIN_PAGE = "EVENT_LAUNCH_LOGIN_PAGE";
        public static string EVENT_LAUNCH_MAIN_PAGE = "EVENT_LAUNCH_MAIN_PAGE";
        private void SetLoginPageAsRootPage(object sender)
        {
            MainPage = new Page1(){

            };
        }

        private void SetMainPageAsRootPage(object sender)
        {
            MainPage = new AppShell();
        }
        public App()
        {
            InitializeComponent();
            MessagingCenter.Subscribe<object>(this, EVENT_LAUNCH_LOGIN_PAGE, SetLoginPageAsRootPage);
            MessagingCenter.Subscribe<object>(this, EVENT_LAUNCH_MAIN_PAGE, SetMainPageAsRootPage);


            DependencyService.Register<MockDataStore>();
            MainPage = new NavigationPage(new Page1());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
