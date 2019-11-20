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
    public partial class SearchbarControl : ContentPage
    {
        private readonly List<string> persons =  new List<string>
        {
                "Stark",
                "John",
                "Targarian",
                "Tirion"
        };
        public SearchbarControl()
        {
            InitializeComponent();
            MainListView.ItemsSource = persons;
        }

        private void MainSearchBar_SearchButtonPressed(object sender, EventArgs e)
        {
            string keyword = MainSearchBar.Text;
            //IEnumerable<string> search_result = persons.Where(name => name.ToLower().Contains(keyword.ToLower()));
            IEnumerable<string> search_result = from name in persons where name.ToLower().Contains(keyword.ToLower()) select name;
            MainListView.ItemsSource = search_result;
        }
    }
}