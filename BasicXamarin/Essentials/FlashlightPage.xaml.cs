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
    public partial class FlashlightPage : ContentPage
    {
        bool isOn;
        public FlashlightPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                if (!isOn)
                {
                    await Flashlight.TurnOnAsync();
                    isOn = true;
                }
                else
                {
                    await Flashlight.TurnOffAsync();
                    isOn = false;
                }
               
            }
            catch (FeatureNotSupportedException fnsEx)
            {
                // Handle not supported on device exception
            }
            catch (PermissionException pEx)
            {
                // Handle permission exception
            }
            catch (Exception)
            {

            }
        }
    }
}