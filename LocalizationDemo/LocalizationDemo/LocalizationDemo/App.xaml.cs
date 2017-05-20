using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace LocalizationDemo
{
    public partial class App : Application
    {
        public static string CurrentLanguage = "EN";
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new LocalizationDemo.MainPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
