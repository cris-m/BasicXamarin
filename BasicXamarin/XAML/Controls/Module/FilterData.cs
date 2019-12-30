using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace BasicXamarin.XAML.Controls.Module
{
    public class FilterData:BindableObject
    {
        public static readonly BindableProperty FilterProperty = BindableProperty.Create(nameof(Filter), typeof(string), typeof(FilterData), null);
        public string Filter
        {
            get { return (string)GetValue(FilterProperty); }
            set { SetValue(FilterProperty, value); }
        }
    }
}
