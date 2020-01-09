using BasicXamarin.Essentials.Service;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BasicXamarin.Essentials
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ConnectivityPage : ContentPage
    {
        public ConnectivityPage()
        {
            InitializeComponent();
            var current = Connectivity.NetworkAccess;
            if(current == NetworkAccess.Internet)
            {
                DisplayAlert("Connectivity", "There is internet connection", "Ok");
            }
            else
            {
                DisplayAlert("Connectivity", "There is no internet connection", "Ok");
            }

            //You can check what type of connection profile the device is actively using:
            var profile = Connectivity.ConnectionProfiles;
            if (profile.Contains(ConnectionProfile.WiFi))
            {
                DisplayAlert("Coonnectivity", "The device is using WIFI", "Ok");
            }

            // on connectivity change
            Connectivity.ConnectivityChanged += Connectivity_ConnectivityChanged;
        }
        private void Connectivity_ConnectivityChanged(object sender, ConnectivityChangedEventArgs e)
        {
            var access = e.NetworkAccess;
            var profile = e.ConnectionProfiles;
            Debug.WriteLine(access.ToString());
        }
    }
}