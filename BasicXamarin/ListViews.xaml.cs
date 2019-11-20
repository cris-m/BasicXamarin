using BasicXamarin.Sources;
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
    public partial class ListViews : ContentPage
    {
        public ListViews()
        {
            InitializeComponent();
            //MainListView.ItemsSource = new List<string>
            //{
            //    "Stark",
            //    "John",
            //    "Targarian",
            //    "Tirion"
            //};

            MainListView.ItemsSource = new List<Person>
            {
                new Person
                {
                    Name = "Stark",
                    Age = 80
                },
                new Person
                {
                    Name = "John",
                    Age = 30
                },
                new Person
                {
                    Name = "Targarian",
                    Age = 28
                },
                new Person
                {
                    Name = "Tirion",
                    Age = 40
                }
            };
        }
    }
}