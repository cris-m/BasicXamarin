using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BasicXamarin.XAML
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class XamlIntroduction : ContentPage
    {
        public XamlIntroduction()
        {
            InitializeComponent();
            Button btn = new Button
            {
                Text = "Click Me",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };
            btn.Clicked += Btn_Clicked;
            //Content = btn;
        }

        private void Btn_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Button", "I have been clicked", "ok");
        }
    }
}