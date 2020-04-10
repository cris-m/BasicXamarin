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
    public partial class PermissionPage : ContentPage
    {
        public PermissionPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var permission = await Permissions.CheckStatusAsync<Permissions.Camera>();
            if(permission!= PermissionStatus.Granted)
            {
                // request permission
                permission = await Permissions.RequestAsync<Permissions.Camera>();
                if (permission != PermissionStatus.Granted)
                {
                    await DisplayAlert("Permission", "Camera permission access denied", "Ok");
                }
                else
                {
                    await DisplayAlert("Permission", "Camera permission access granted", "Ok");
                }
            }
            else
            {
                await DisplayAlert("Permission", "Camera permission exist", "Ok");
            }
           
        }
    }
}