using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace BasicXamarin.XAML.Module
{
    public class HslViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private Double hue, saturation, luminosity;
        private Color color;

        public double Luminosity
        {
            get { return luminosity;  }
            set
            {
                if(luminosity != value)
                {
                    luminosity = value;
                    OnPropertyChanged("Luminosity");
                    SetColor();
                }
            }
        }
        public double Hue
        {
            get { return hue; }
            set
            {
                if (hue != value)
                {
                    hue = value;
                    OnPropertyChanged("Hue");
                    SetColor();
                }
            }
        }
        public double Saturation
        {
            get { return saturation; }
            set
            {
                if (saturation != value)
                {
                    saturation = value;
                    OnPropertyChanged("Saturation");
                    SetColor();
                }
            }
        }
        public Color Color
        {
            get { return color; }
            set
            {
                if (color != value)
                {
                    color = value;
                    OnPropertyChanged("Color");
                    Hue = value.Hue;
                    Saturation = value.Saturation;
                    Luminosity = value.Luminosity;
                }
            }
        }
        public void SetColor()
        {
            Color = Color.FromHsla(Hue, Saturation, Luminosity);
        }
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
