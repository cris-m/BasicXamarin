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
    public partial class DeviceDisplayInfoPage : ContentPage
    {
        public DeviceDisplayInfoPage()
        {
            InitializeComponent();
            var mainDisplayInfo = DeviceDisplay.MainDisplayInfo;
            var orientation = mainDisplayInfo.Orientation;
            var rotation = mainDisplayInfo.Rotation;
            var width = mainDisplayInfo.Width;
            var height = mainDisplayInfo.Height;
            var density = mainDisplayInfo.Density;

            Lorientation.Text += orientation.ToString();
            Lrotation.Text += rotation.ToString();
            Lwidth.Text += width.ToString();
            Lheight.Text += height.ToString();
            Ldensity.Text += density.ToString();
            DeviceDisplay.MainDisplayInfoChanged += DeviceDisplay_MainDisplayInfoChanged;

            //The DeviceDisplay class exposes a bool property called KeepScreenOn that can be set to attempt to keep the device's display from turning off or locking
            DeviceDisplay.KeepScreenOn = !DeviceDisplay.KeepScreenOn;
        }

        private void DeviceDisplay_MainDisplayInfoChanged(object sender, DisplayInfoChangedEventArgs e)
        {
            var displayInfo = e.DisplayInfo;
            var orientation = displayInfo.Orientation;
            var rotation = displayInfo.Rotation;
            Lorientation.Text = orientation.ToString();
            Lrotation.Text = rotation.ToString();
        }
    }
}