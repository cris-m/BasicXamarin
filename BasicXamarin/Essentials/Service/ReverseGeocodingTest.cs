using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace BasicXamarin.Essentials.Service
{
   public class ReverseGeocodingTest: INotifyPropertyChanged
    {
        private string adress;
        public event PropertyChangedEventHandler PropertyChanged;
        public string Adress
        {
            get
            {
                return adress;
            }
            set
            {
                if (adress != value)
                {
                    adress = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Adress"));
                }
            }
        }
        public ReverseGeocodingTest()
        {
            Task.Run(() =>
            {
                GetAddress();
            });
        }

        private async void GetAddress()
        {
            try
            {
                var lat = 47.673988;
                var lon = -122.121513;

                var placemarks = await Geocoding.GetPlacemarksAsync(lat, lon);

                var placemark = placemarks?.FirstOrDefault();
                if (placemark != null)
                {
                    Adress =
                        $"AdminArea:       {placemark.AdminArea}\n" +
                        $"CountryCode:     {placemark.CountryCode}\n" +
                        $"CountryName:     {placemark.CountryName}\n" +
                        $"FeatureName:     {placemark.FeatureName}\n" +
                        $"Locality:        {placemark.Locality}\n" +
                        $"PostalCode:      {placemark.PostalCode}\n" +
                        $"SubAdminArea:    {placemark.SubAdminArea}\n" +
                        $"SubLocality:     {placemark.SubLocality}\n" +
                        $"SubThoroughfare: {placemark.SubThoroughfare}\n" +
                        $"Thoroughfare:    {placemark.Thoroughfare}\n";
                }
            }
            catch (FeatureNotSupportedException)
            {
                // Feature not supported on device
            }
            catch (Exception)
            {
                // Handle exception that may have occurred in geocoding
            }
        }
    }
}
