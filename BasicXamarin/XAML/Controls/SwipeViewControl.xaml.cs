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
    public partial class SwipeViewControl : ContentPage
    {
        public SwipeViewControl()
        {
            InitializeComponent();
        }

        private void SwipeItem_Invoked(object sender, EventArgs e)
        {

        }
    }
}