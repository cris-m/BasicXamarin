using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BasicXamarin.Essentials
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BatteryPage : ContentPage
    {
        public BatteryPage()
        {
            InitializeComponent();
            SetBackgroundColor(Battery.ChargeLevel, Battery.State == BatteryState.Charging);
            Battery.EnergySaverStatusChanged += Battery_EnergySaverStatusChanged;
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            Battery.BatteryInfoChanged += Battery_BatteryInfoChanged;
        }
        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            Battery.BatteryInfoChanged -= Battery_BatteryInfoChanged;
            Battery.EnergySaverStatusChanged -= Battery_EnergySaverStatusChanged;
        }

        private void Battery_EnergySaverStatusChanged(object sender, EnergySaverStatusChangedEventArgs e)
        {
            var status = e.EnergySaverStatus;
            if(status == EnergySaverStatus.On)
            {
                // avoid background task
                Debug.WriteLine("Avoid background task");
            }
        }

        private void Battery_BatteryInfoChanged(object sender, BatteryInfoChangedEventArgs e)
        {
            SetBackgroundColor(e.ChargeLevel, e.State == BatteryState.Charging);
        }

        public void SetBackgroundColor(double level, bool isCharging)
        {
            Color? color = null;
            var status = isCharging ? "Charging" : "Not Charging";
            if(level > .5f) // 50%
            {
                color = Color.Green.MultiplyAlpha(level);
            }
            else if(level > .2f) // 20%
            {
                color = Color.Yellow.MultiplyAlpha(1d - level);
            }
            else
            {
                color = Color.Red.MultiplyAlpha(1d - level);
            }
            MainBoxView.BackgroundColor = color.Value;
            MainLabel.Text = status;
            MainLabel1.Text = Battery.PowerSource.ToString();
        }
    }
}