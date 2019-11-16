using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BasicXamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1Navigation : ContentPage
    {
        public Page1Navigation()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            string text = Entry1Text.Text;
            if(text!= string.Empty)
            {
                await Navigation.PushAsync(new Page2Navigation(text));
            }
        }
    }
}