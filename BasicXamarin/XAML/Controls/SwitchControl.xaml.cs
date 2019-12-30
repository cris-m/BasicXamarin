using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BasicXamarin.XAML.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SwitchControl : ContentPage
    {
        public SwitchControl()
        {
            InitializeComponent();
            //Switch MainSwitch = new Switch
            //{
            //    IsToggled = true,
            //    HorizontalOptions = LayoutOptions.Center,
            //    VerticalOptions = LayoutOptions.CenterAndExpand
            //};
            //Content = new StackLayout
            //{
            //    Children =
            //    {
            //        MainSwitch
            //    }
            //};
        }

        private void Switch_Toggled(object sender, ToggledEventArgs e)
        {
            // Perform an action after examining e.Value
            DisplayAlert("Switch", "I have been toggle", "Ok");
        }
    }
}