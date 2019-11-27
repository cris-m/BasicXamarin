using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

namespace BasicXamarin.Essentials
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AccelerometerPage : ContentPage
    {
        public AccelerometerPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            // start accelerometer
            // check if we alredy minitoring
            if (Accelerometer.IsMonitoring)
                return;
            // subscribe reading event
            Accelerometer.ReadingChanged += Accelerometer_ReadingChanged;
            // start the accelerometer
            Accelerometer.Start(SensorSpeed.UI);
        }

        private void Accelerometer_ReadingChanged(object sender, AccelerometerChangedEventArgs e)
        {
            LabelX.Text = e.Reading.Acceleration.X.ToString();
            LabelY.Text = e.Reading.Acceleration.Y.ToString();
            LabelZ.Text = e.Reading.Acceleration.Z.ToString();
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            // stop accelerometer
            // check if we alredy minitoring
            if (!Accelerometer.IsMonitoring)
                return;
            // unsubscribe to reading event
            Accelerometer.ReadingChanged -= Accelerometer_ReadingChanged;
            // stop the accelerometer
            Accelerometer.Stop();
        }
    }
}