using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;

namespace BasicXamarin.Essentials.Service
{
    public class ConnectivityTest
    {
        public ConnectivityTest()
        {
            Connectivity.ConnectivityChanged += Connectivity_ConnectivityChanged;
        }

        private void Connectivity_ConnectivityChanged(object sender, ConnectivityChangedEventArgs e)
        {
            var access = e.NetworkAccess;
            var profile = e.ConnectionProfiles;
        }
    }
}
