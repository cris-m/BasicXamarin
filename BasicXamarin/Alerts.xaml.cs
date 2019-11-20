using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BasicXamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Alerts : ContentPage
    {
        public Alerts()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            //DisplayAlert("Notification", "Do you want to save?", "Save", "Don't save");
            var answer = await DisplayAlert("Notification", "Do you want to save?", "Save", "Don't save");
            //Debug.WriteLine("Answer: " + (answer ? "Save" : "Don't save"));
            if(answer == true)
            {
                Debug.WriteLine("Save");
            }
            else
            {
                Debug.WriteLine("Dont'save");
            }
        }
    }
}