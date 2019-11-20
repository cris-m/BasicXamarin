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
    public partial class DatepickerControl : ContentPage
    {
        public DatepickerControl()
        {
            InitializeComponent();
        }

        private void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {
            Debug.WriteLine(e.NewDate.ToString());
            MainLabel.Text = e.NewDate.ToShortDateString();
        }
    }
}