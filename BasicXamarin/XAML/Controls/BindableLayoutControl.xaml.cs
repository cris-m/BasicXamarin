using BasicXamarin.XAML.Controls.Module;
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
    public partial class BindableLayoutControl : ContentPage
    {
        public UserViewModel ViewModel { get; set; }
        public BindableLayoutControl()
        {
            InitializeComponent();
            this.BindingContext = new UserViewModel();
        }
    }
}