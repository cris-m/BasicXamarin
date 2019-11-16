using BasicXamarin.ViewModels;
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
    public partial class Converters : ContentPage
    {
        public Converters()
        {
            InitializeComponent();
            BindingContext = new TaskViewModel();
        }
    }
}