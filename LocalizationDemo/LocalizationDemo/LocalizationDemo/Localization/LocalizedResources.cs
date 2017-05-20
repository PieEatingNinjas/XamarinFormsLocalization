using System;
using System.ComponentModel;
using System.Globalization;
using System.Resources;
using Xamarin.Forms;

namespace LocalizationDemo.Localization
{
    public class LocalizedResources : INotifyPropertyChanged
    {
        const string DEFAULT_LANGUAGE = "en";

        readonly ResourceManager ResourceManager;
        CultureInfo CurrentCultureInfo;

        public string this[string key]
        {
            get
            {
                return ResourceManager.GetString(key, CurrentCultureInfo);
            }
        }

        public LocalizedResources(Type resource, string language = null) 
            : this(resource, new CultureInfo(language ?? DEFAULT_LANGUAGE))
        {  }

        public LocalizedResources(Type resource, CultureInfo cultureInfo)
        {
            CurrentCultureInfo = cultureInfo;
            ResourceManager = new ResourceManager(resource);

            MessagingCenter.Subscribe<object, CultureChangedMessage>(this, 
                string.Empty, OnCultureChanged);
        }

        private void OnCultureChanged(object s, CultureChangedMessage ccm)
        {
            CurrentCultureInfo = ccm.NewCultureInfo;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Item"));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
