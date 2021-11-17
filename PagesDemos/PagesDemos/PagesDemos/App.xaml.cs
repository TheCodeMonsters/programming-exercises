using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PagesDemos
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new  NavigationPage(new MainPage());
            MainPage = new HomePage();
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
