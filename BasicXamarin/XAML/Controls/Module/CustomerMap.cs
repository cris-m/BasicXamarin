using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms.Maps;

namespace BasicXamarin.XAML.Controls.Module
{
    public class CustomerMap: Map
    {
        public List<CustomerPin> CustomerPins { get; set; }
    }
}
