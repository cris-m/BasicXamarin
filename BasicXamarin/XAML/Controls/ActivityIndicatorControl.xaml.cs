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
    public partial class ActivityIndicatorControl : ContentPage
    {
        public ActivityIndicatorControl()
        {
            InitializeComponent();
            //ActivityIndicator activityIndicator = new ActivityIndicator { IsRunning = true };
            //Content = new StackLayout
            //{
            //    Children =
            //    {
            //        activityIndicator
            //    }
            //};
        }
    }
}