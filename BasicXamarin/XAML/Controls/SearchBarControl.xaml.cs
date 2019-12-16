using BasicXamarin.XAML.Controls.Service;
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
    public partial class SearchBarControl : ContentPage
    {
        public SearchBarControl()
        {
            InitializeComponent();

            // searchbar in code
            //SearchBar search = new SearchBar
            //{
            //    Placeholder = "Search items...",
            //    PlaceholderColor = Color.Orange,
            //    TextColor = Color.Orange,
            //    HorizontalTextAlignment = TextAlignment.Center,
            //    FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(SearchBar)),
            //    FontAttributes = FontAttributes.Italic
            //};
            //Content = new StackLayout
            //{
            //    Children =
            //    {
            //        search
            //    }
            //};

            //searchBarResult.ItemsSource = DataSearchService.Items;
        }

        //private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        //{
        //    SearchBar searchBar = (SearchBar)sender;
        //    searchBarResult.ItemsSource = DataSearchService.GetSearchResult(searchBar.Text);
        //}
    }
}