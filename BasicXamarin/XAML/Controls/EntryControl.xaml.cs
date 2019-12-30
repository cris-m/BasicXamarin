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
    public partial class EntryControl : ContentPage
    {
        public EntryControl()
        {
            InitializeComponent();
            //Entry MainEntry = new Entry
            //{
            //    Text = "This is an entry"
            //};
            //Content = new StackLayout
            //{
            //    Children =
            //    {
            //        MainEntry
            //    }
            //};
        }

        private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            var oldText = e.OldTextValue;
            var newText = e.NewTextValue;
        }

        private void Entry_Completed(object sender, EventArgs e)
        {
            var text = ((Entry)sender).Text;
        }
    }
}