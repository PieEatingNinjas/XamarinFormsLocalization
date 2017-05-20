using LocalizationDemo.Localization;
using LocalizationDemo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LocalizationDemo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            this.BindingContext = new MainPageViewModel();
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SettingsPage());
        }
    }
}
