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
    public partial class BarometerPage : ContentPage
    {
        SensorSpeed speed = SensorSpeed.UI;
        public BarometerPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                if (Barometer.IsMonitoring)
                {
                    Barometer.Stop();
                }
                else
                {
                    Barometer.ReadingChanged += Barometer_ReadingChanged;
                    Barometer.Start(speed);
                }
            }
            catch (Exception) { }
        }

        private void Barometer_ReadingChanged(object sender, BarometerChangedEventArgs e)
        {
            var data = e.Reading;
            MainLabel.Text = $"Reading Pressure: {data.PressureInHectopascals} hectopascals";
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            try
            {
                if (Barometer.IsMonitoring)
                {
                    Barometer.ReadingChanged -= Barometer_ReadingChanged;
                    Barometer.Stop();
                }
            }
            catch (Exception) { }
        }
    }
}