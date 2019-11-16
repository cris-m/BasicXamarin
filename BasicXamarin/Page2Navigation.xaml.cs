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
    public partial class Page2Navigation : ContentPage
    {
        public Page2Navigation(string parameter)
        {
            InitializeComponent();
            Entry2Text.Text = parameter;
        }
    }
}