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
    public partial class UIProperties : ContentPage
    {
        public UIProperties()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            string text = EntryText.Text;
            LabelText.Text = "Hello "+ text;
        }
    }
}