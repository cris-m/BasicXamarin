using System;
using System.Collections.Generic;
using System.Text;

namespace BasicXamarin.XAML.Module
{
    public class PageDataViewModel
    {
        public Type Type { get; set; }
        public string Title { get; set; }
        public string Desciption { private get; set; }
        public static IList<PageDataViewModel> All { get; set; }
        public PageDataViewModel(Type type, string title, string description)
        {
            Type = type;
            Title = title;
            Desciption = description;
        }

        static PageDataViewModel()
        {
            All = new List<PageDataViewModel>
            {
                new PageDataViewModel(typeof(XamlIntroduction), "Xaml Introduction", "Just Introduction to XAML"),
                new PageDataViewModel(typeof(XamlDataBinding), "Xaml Databinding", "It is an example of manipulatiing data from UI to the internal app"),
                new PageDataViewModel(typeof(XamlMarkup), "Xaml Markup", "Introduction to XAML markup language")
            };
        }
    }
}
