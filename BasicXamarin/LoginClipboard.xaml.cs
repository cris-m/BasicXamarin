using BasicXamarin.Essentials;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BasicXamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginClipboard : ContentPage
    {
        public LoginClipboard()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
           if(email.Text.Trim() == "xamarin@example.com" && password.Text.Trim() == "aaaaaaaa")
            {
                await Clipboard.SetTextAsync("1234");
                await Navigation.PushAsync(new ClipboardPage());
            }

        }
    }
}