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
    public partial class ButtonControl : ContentPage
    {
        public ButtonControl()
        {
            InitializeComponent();

            //button in the code
            //Label label = new Label
            //{
            //    Text = "Some text",
            //    FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
            //    VerticalOptions = LayoutOptions.CenterAndExpand,
            //    HorizontalOptions = LayoutOptions.Center
            //};
            //Button button = new Button
            //{
            //    Text = "Click to Rotate Text!",
            //    VerticalOptions = LayoutOptions.CenterAndExpand,
            //    HorizontalOptions = LayoutOptions.Center
            //};
            //button.Clicked += async (sender, args) => { await label.RelRotateTo(360, 1000); };
            //Content = new StackLayout
            //{
            //    Children =
            //    {
            //        label,
            //        button
            //    }
            //};

            // command interface on button
        }

        //private async void Button_Clicked(object sender, EventArgs e)
        //{
        //    await MainLabel.RelRotateTo(360, 1000);
        //}
    }
}