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
    public partial class DeviceShakePage : ContentPage
    {
        SensorSpeed sensorSpeed = SensorSpeed.Game;
        public DeviceShakePage()
        {
            InitializeComponent();
            //ToggleAccelerometer();
            Accelerometer.ShakeDetected += Accelerometer_ShakeDetected;
        }

        private void Accelerometer_ShakeDetected(object sender, EventArgs e)
        {
            MainThread.BeginInvokeOnMainThread(() =>
            {
                MainEntry.Text = string.Empty;
            });
        }
        public void ToggleAccelerometer()
        {
            try
            {
                if (Accelerometer.IsMonitoring)
                    Accelerometer.Stop();
                else
                    Accelerometer.Start(sensorSpeed);
            }
            catch (FeatureNotSupportedException fnsEx)
            {
                // Feature not supported on device
            }
            catch (Exception ex)
            {
                // Other error has occurred.
            }
        }
        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            Accelerometer.ShakeDetected -= Accelerometer_ShakeDetected;
            Accelerometer.Stop();
        }
    }
}