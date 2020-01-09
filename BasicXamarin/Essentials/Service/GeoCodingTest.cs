using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace BasicXamarin.Essentials.Service
{
    public class GeoCodingTest : INotifyPropertyChanged
    {
        private string latitude;
        private string longitude;

        public string Latitude
        {
            get
            {
                return latitude;
            }
            set
            {
                if (latitude != value)
                {
                    latitude = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Latitude"));
                }
            }
        }
        public string Longitude
        {
            get
            {
                return longitude;
            }
            set
            {
                if (longitude != value)
                {
                    longitude = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Longitude"));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public GeoCodingTest()
        {
            Task.Run( () =>
            {
                 GetAddress();
            });
        }

        public async void GetAddress()
        {
            try
            {
                var address = "Microsoft Building 25 Redmond WA USA";
                var locations = await Geocoding.GetLocationsAsync(address);
                var location = locations?.FirstOrDefault();
                if (location != null)
                {
                    Latitude = location.Latitude.ToString();
                    Longitude = location.Longitude.ToString();
                }
            }
            catch (FeatureNotSupportedException)
            {

            }
            catch (Exception)
            {

            }
        }

        
    }
}
