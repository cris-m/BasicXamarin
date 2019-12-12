using BasicXamarin.XAML.Module;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BasicXamarin.XAML
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NavigationMenu : ContentPage
    {
        public NavigationMenu()
        {
            InitializeComponent();
        }

        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            (sender as ListView).SelectedItem = null;
            if(e.SelectedItem != null)
            {
                PageDataViewModel pageData = e.SelectedItem as PageDataViewModel;
                Page page = (Page)Activator.CreateInstance(pageData.Type);
                await Navigation.PushAsync(page);
            }
        }
    }
}