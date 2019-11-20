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
    public partial class ToolBars : ContentPage
    {
        public ToolBars()
        {
            InitializeComponent();
        }

        private void MenuItem1_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Menu clicked", "A ToolBar Item was clicked", "Ok");
        }
    }
}