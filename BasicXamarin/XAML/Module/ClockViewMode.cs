using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace BasicXamarin.XAML.Module
{
    public class ClockViewMode : INotifyPropertyChanged
    {
        private DateTime datetime;
        public event PropertyChangedEventHandler PropertyChanged;
        public DateTime Datetime
        {
            get { return datetime; }
            set
            {
                if(datetime != value)
                {
                    datetime = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("Datetime"));
                    }
                }
            }
        }

        public ClockViewMode()
        {
            this.Datetime = DateTime.Now;
            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                this.Datetime = DateTime.Now;
                return true;
            });
        }
    }
}
