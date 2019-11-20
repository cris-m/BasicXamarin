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
    public partial class ActionMenus : ContentPage
    {
        public ActionMenus()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var color = await DisplayActionSheet("Background Color", "Cancel", null, "Blue", "Yellow", "Green", "Red");
            if(color == "Blue")
            {
                BackgroundColor = Color.Blue;
            }
            else if (color == "Yellow")
            {
                BackgroundColor = Color.Yellow;
            }
            else if (color == "Green")
            {
                BackgroundColor = Color.Green;
            }
            else if (color == "Red")
            {
                BackgroundColor = Color.Red;
            }
        }
    }
}