using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BasicXamarin.Testing.UITest
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UITestPage : ContentPage
    {
        public UITestPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            ResultLabel.Text = (Convert.ToInt32(ValueAEntry.Text) + Convert.ToInt32(ValueBEntry.Text)).ToString();
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            ResultLabel.Text = (Convert.ToInt32(ValueAEntry.Text) * Convert.ToInt32(ValueBEntry.Text)).ToString();
        }
    }
}