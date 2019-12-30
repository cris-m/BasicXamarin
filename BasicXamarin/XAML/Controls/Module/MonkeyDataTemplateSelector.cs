using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace BasicXamarin.XAML.Controls.Module
{
    public class MonkeyDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate AfricaMonkey { get; set; }
        public DataTemplate OtherMonkey { get; set; }
        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            return ((Monkey)item).Location.Contains("Africa") ? AfricaMonkey : OtherMonkey;
        }
    }
}
