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
    public partial class StepperControl : ContentPage
    {
        public StepperControl()
        {
            InitializeComponent();
            //Label label = new Label
            //{
            //    Text = "Roteting text",
            //    FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
            //    HorizontalOptions = LayoutOptions.Center,
            //    VerticalOptions = LayoutOptions.CenterAndExpand
            //};
            //Label displayLabel = new Label
            //{
            //    Text = "(uninitialized)",
            //    HorizontalOptions = LayoutOptions.Center,
            //    VerticalOptions = LayoutOptions.CenterAndExpand
            //};
            //Stepper MainStepper = new Stepper
            //{
            //    Maximum = 360,
            //    Minimum = 0,
            //    HorizontalOptions = LayoutOptions.Center
            //};
            //MainStepper.ValueChanged += (sender, e) =>
            //  {
            //      label.Rotation = e.NewValue;
            //      displayLabel.Text = string.Format("The Stepper value is {0}", e.NewValue);
            //  };
            //Content = new StackLayout
            //{
            //    Margin = new Thickness(20),
            //    Children =
            //    {
            //        label,
            //        displayLabel,
            //        MainStepper
            //    }
            //};
        }

        //private void Stepper_ValueChanged(object sender, ValueChangedEventArgs e)
        //{
        //    MainLabel.Rotation = e.NewValue;
        //    DisplayLabel.Text = string.Format("The Stepper value is {0}", e.NewValue);
        //}
    }
}