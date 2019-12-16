using BasicXamarin.XAML.Controls.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace BasicXamarin.XAML.Controls.Module
{
    public class SearchViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public ICommand SearchCommand => new Command<string>((string query) =>
        {
            SearchList = DataSearchService.GetSearchResult(query);
        });
        private List<string> searchList = DataSearchService.Items;
        public List<string> SearchList
        {
            get
            {
                return searchList;
            }
            set
            {
                searchList = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SearchList"));
            }
        }
    }
}
