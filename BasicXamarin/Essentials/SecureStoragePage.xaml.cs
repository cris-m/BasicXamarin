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
    public partial class SecureStoragePage : ContentPage
    {
        public SecureStoragePage()
        {
            InitializeComponent();
            MainThread.BeginInvokeOnMainThread(async() =>
            {
                try
                {
                    var oauthToken = await SecureStorage.GetAsync("oauth_token");
                    if (!string.IsNullOrEmpty(oauthToken))
                    {
                        MainLabel.Text = oauthToken;
                    }
                }
                catch (Exception ex)
                {
                    // Possible that device doesn't support secure storage on device.
                }
            });
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {

                await SecureStorage.SetAsync("oauth_token", MainEntry.Text);
            }
            catch (Exception ex)
            {
                // Possible that device doesn't support secure storage on device.
            }
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            SecureStorage.Remove("oauth_token");
            //SecureStorage.RemoveAll(); remove all key
        }
    }
}