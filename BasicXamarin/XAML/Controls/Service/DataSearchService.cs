using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicXamarin.XAML.Controls.Service
{
    public static class DataSearchService
    {

        public static List<string> Items = new List<string>
        {
            "Iphone 5s",
            "Iphone X",
            "Samsung Galaxy S8",
            "Dell Latitude E5540",
            "Lenovo Thinkpad Yoga",
            "Samsung Galaxy S6",
            "Samsung S6",
            "Google Pixel 4",
            "Samsung Galaxy S10e",
            "Alcatel Go Flip 3",
            "Motorola Moto G7 Power",
            "Apple iPhone 11 Pro"
         };
        public static List<string>GetSearchResult(string query)
        {
            var normalizeQuery = query?.ToLower() ?? ""; //if the query is null it convert it to empty string
            return Items.Where(item => item.ToLowerInvariant().Contains(normalizeQuery)).ToList();
        }
    }
}
