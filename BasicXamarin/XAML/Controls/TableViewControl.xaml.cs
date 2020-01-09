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
    public partial class TableViewControl : ContentPage
    {
        public TableViewControl()
        {
            InitializeComponent();
        }

        //private void _viewCell_Tapped(object sender, EventArgs e)
        //{
        //    _target.IsVisible = !_target.IsVisible;
        //    _viewCell.ForceUpdateSize();
        //}
    }
}