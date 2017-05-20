using LocalizationDemo.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LocalizationDemo
{
    public partial class SettingsPage : ContentPage
    {
        public SettingsPage()
        {
            BindingContext = new SettingsViewModel();
            InitializeComponent();
        }
    }
}