using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BasicXamarin.XAML.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TimePickerControl : ContentPage
    {
        DateTime _triggerTime;
        public TimePickerControl()
        {
            InitializeComponent();
            //TimePicker timePicker = new TimePicker
            //{
            //    Time = new TimeSpan(4, 12, 26)
            //};
            //Content = new StackLayout
            //{
            //    Children =
            //    {
            //        timePicker
            //    }
            //};

            Device.StartTimer(TimeSpan.FromSeconds(1), OnTimerTick);
        }

        private bool OnTimerTick()
        {
            if (_switch.IsToggled && DateTime.Now >= _triggerTime)
            {
                _switch.IsToggled = false;
                DisplayAlert("Timer Alert", "The '" + _entry.Text + "' timer has elapsed", "OK");
            }
            return true;
        }
        void OnTimePickerPropertyChanged(object sender, PropertyChangedEventArgs args)
        {
            if (args.PropertyName == "Time")
            {
                SetTriggerTime();
            }
        }

        void OnSwitchToggled(object sender, ToggledEventArgs args)
        {
            SetTriggerTime();
        }

        void SetTriggerTime()
        {
            if (_switch.IsToggled)
            {
                _triggerTime = DateTime.Today + _timePicker.Time;
                if (_triggerTime < DateTime.Now)
                {
                    _triggerTime += TimeSpan.FromDays(1);
                }
            }
        }
    }
}