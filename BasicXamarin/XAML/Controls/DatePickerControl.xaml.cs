using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BasicXamarin.XAML.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DatePickerControl : ContentPage
    {
        public DatePickerControl()
        {
            InitializeComponent();
            //Initializing the DateTime properties
            //DatePicker datePicker = new DatePicker
            //{
            //    MinimumDate = new DateTime(2019, 1, 1),
            //    MaximumDate = new DateTime(2019, 12, 31),
            //    Date = new DateTime(2019, 12, 1)
            //};
            //Content = new StackLayout
            //{
            //    Margin = new Thickness(5),
            //    Children =
            //    {
            //        datePicker
            //    }
            //};
        }
        void OnDateSelected(object sender, DateChangedEventArgs args)
        {
            Recalculate();
        }

        void OnSwitchToggled(object sender, ToggledEventArgs args)
        {
            Recalculate();
        }
        public void Recalculate()
        {
            TimeSpan timeSpan = endDatePicker.Date - startDatePicker.Date +
                (includeSwitch.IsToggled ? TimeSpan.FromDays(1) : TimeSpan.Zero);

            resultLabel.Text = String.Format("{0} day {1} between dates",
                                             timeSpan.Days, timeSpan.Days == 1 ? "" : "s");
        }
    }
}