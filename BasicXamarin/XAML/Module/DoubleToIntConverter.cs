using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace BasicXamarin.XAML.Module
{
    public class DoubleToIntConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            double multiple;
            if(!Double.TryParse(parameter as string, out multiple))
            {
                multiple = 1;
            }
            return (int)Math.Round(multiple * (double)value);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            double divider;
            if (!Double.TryParse(parameter as string, out divider))
            {
                divider = 1;
            }
            return ((Double)(int)value)/divider;
        }
    }
}
