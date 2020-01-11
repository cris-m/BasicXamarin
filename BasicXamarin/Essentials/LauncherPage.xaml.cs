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
    public partial class LauncherPage : ContentPage
    {
        public LauncherPage()
        {
            InitializeComponent();
        }
        public async Task OpenMapAsync()
        {
            double latitude = 40.765819;
            double longitude = -73.975866;
            string placeName = "Home";
            var supportUri = await Launcher.CanOpenAsync("comgooglemaps://");
            if (supportUri)
            {
                await Launcher.OpenAsync($"comgooglemaps://?q={latitude},{longitude}({placeName})");
            }
            else
            {
                await Map.OpenAsync(40.765819, -73.975866, new MapLaunchOptions { Name = "Test" });
            }
        }
       

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await OpenMapAsync();
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {

        }
    }
}