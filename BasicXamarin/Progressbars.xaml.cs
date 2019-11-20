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
    public partial class Progressbars : ContentPage
    {
        public Progressbars()
        {
            InitializeComponent();
            //MainProgressbar.Progress = 0.8;
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await MainProgressbar.ProgressTo(0.8, 900, Easing.Linear);

        }
    }
}