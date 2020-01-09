using BasicXamarin.Essentials.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BasicXamarin.Essentials
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GeocodingPage : ContentPage
    {
        public GeocodingPage()
        {
            InitializeComponent();
            //BindingContext = new GeoCodingTest();
            // reverse geo coding
            BindingContext = new ReverseGeocodingTest();

        }
    }
}