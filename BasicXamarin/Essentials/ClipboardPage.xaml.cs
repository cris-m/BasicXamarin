using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BasicXamarin.Essentials
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ClipboardPage : ContentPage
    {
        public ClipboardPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if(EntryPIN.Text.Trim() == "1234")
            {
                DisplayAlert("Authentication", "2 Factor Authentication Activated", "Ok");
            }
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            if (Clipboard.HasText)
            {
                var text = await Clipboard.GetTextAsync();
                if(text.Length == 4)
                {
                    EntryPIN.Text = text;
                }
            }
        }
    }
}