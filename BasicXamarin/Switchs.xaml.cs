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
    public partial class Switchs : ContentPage
    {
        public Switchs()
        {
            InitializeComponent();
        }

        //private void MainSwitch_Toggled(object sender, ToggledEventArgs e)
        //{
        //    bool isToggle = e.Value;
        //    MainLabel.Text = isToggle.ToString();
        //}
    }
}