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
    public partial class Pickers : ContentPage
    {
        public Pickers()
        {
            InitializeComponent();
            MainPicker.ItemsSource = new List<string>
            {
                "Congo",
                "Rwanda",
                "Burundi",
                "Uganda",
                "Kenya",
            };
        }

        private void MainPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            string country = MainPicker.Items[MainPicker.SelectedIndex];
            DisplayAlert(country, "Select Country", "Ok");
        }
    }
}