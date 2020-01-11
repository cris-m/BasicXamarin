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
    public partial class PreferencesPage : ContentPage
    {
        public PreferencesPage()
        {
            InitializeComponent();
            var name = Preferences.Get("user_key", string.Empty);
            if (!string.IsNullOrEmpty(name))
            {
                MainLabel.Text = name;
            }
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Preferences.Set("user_key", MainEntry.Text);
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Preferences.Remove("user_key");
            //Preferences.Clear(); clean all the app preference
        }
    }
}