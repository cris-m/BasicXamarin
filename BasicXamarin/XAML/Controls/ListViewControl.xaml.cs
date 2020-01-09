using BasicXamarin.XAML.Controls.Module;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BasicXamarin.XAML.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewControl : ContentPage
    {
        //ObservableCollection<Employee> employees = new ObservableCollection<Employee>();
        //public ObservableCollection<Employee> Employees
        //{
        //    get { return employees; }
        //}

        //ObservableCollection<Item> items = new ObservableCollection<Item>();
        //public ObservableCollection<Item> Items
        //{
        //    get { return items; }
        //}
        private ObservableCollection<ProductGroup> grouped { get; set; }

        public ListViewControl()
        {
            InitializeComponent();
            //var listView = new ListView();
            //listView.ItemsSource = new string[]
            //{
            //  "mono",
            //  "monodroid",
            //  "monotouch",
            //  "monorail",
            //  "monodevelop",
            //  "monotone",
            //  "monopoly",
            //  "monomodal",
            //  "mononucleosis"
            //};
            //Content = listView;

            //Databinding
            //MainListView.ItemsSource = Employees;
            //employees.Add(new Employee { DisplayName = "Wrestler Indybrick" });
            //employees.Add(new Employee { DisplayName = "Burt Keith Joyce-Purdy" });
            //employees.Add(new Employee { DisplayName = "Sheri Finnerty" });
            //employees.Add(new Employee { DisplayName = "Dr. Bill Geri-Beth Hooper" });
            //employees.Add(new Employee { DisplayName = "Spruce Rob" });

            //items.Add(new Item { Name = "Iphone 5SE", Detail = "The most good phone apple never made", Image= "https://upload.wikimedia.org/wikipedia/commons/6/6b/IPhone_SE_rose_gold_rear.png" });
            //items.Add(new Item { Name = "Dell Latitude", Detail = "No Comment", Image= "https://upload.wikimedia.org/wikipedia/en/e/e9/Del_Latitude_E5570.jpg" });
            //items.Add(new Item { Name = "Pizza", Detail = "Food most eaten", Image= "https://upload.wikimedia.org/wikipedia/commons/a/a3/Eq_it-na_pizza-margherita_sep2005_sml.jpg" });
            //items.Add(new Item { Name = "Tomato", Detail = "Actual fruit", Image= "https://upload.wikimedia.org/wikipedia/commons/7/7a/Tomato_plant_1.jpg" });
            //items.Add(new Item { Name = "Zucchini", Detail = "Grows relavely easily", Image= "https://upload.wikimedia.org/wikipedia/commons/0/08/Courgette_J1.JPG" });
            //BindingContext = this;

            //grouped = new ObservableCollection<ProductGroup>();
            //grouped.Add(
            //new ProductGroup("Tech", "A")
            //{
            //    new Product
            //    {
            //        Name = "Iphone 5SE",
            //        Brand = "Apple"
            //    },
            //    new Product
            //    {
            //        Name = "Dell Latitude E5540",
            //        Brand = "Dell"
            //    }
            //});
            //grouped.Add(new ProductGroup("Cars", "B")
            //{
            //    new Product
            //    {
            //        Name = "Toyota Prius",
            //        Brand = "Toyota"
            //    },
            //    new Product
            //    {
            //        Name = "Bugatti Veyron",
            //        Brand = "Bugatti"
            //    },
            //    new Product
            //    {
            //        Name = "Mercedes-Benz SL-Class SL 350",
            //        Brand = "Mercedes-Benz"
            //    },
            //    new Product
            //    {
            //        Name = "Toyota Tacoma",
            //        Brand = "Toyota"
            //    }
            //});
            //grouped.Add(new ProductGroup("Shoes", "C")
            //{
            //    new Product
            //    {
            //        Name = "Air Jordan 4 Retro WNTR",
            //        Brand = "Nike"
            //    },
            //    new Product
            //    {
            //        Name = "Nike Renew Run",
            //        Brand = "Nike"
            //    },
            //    new Product
            //    {
            //        Name = "NMD_R1 Shoes",
            //        Brand = "Adidas"
            //    },
            //    new Product
            //    {
            //        Name = "Busenitz Shoes",
            //        Brand = "Adidas"
            //    }
            //});
            //MainListView.ItemsSource = grouped;

            // context menu
            //MainListView.ItemsSource = new string[]
            //{
            //    "NMD_R1 Shoes",
            //    "Air Jordan 4 Retro WNTR",
            //    "Nike Renew Run",
            //    "Busenitz Shoes"
            //};

            // Customer Viewcell
            List<Person> persons = new List<Person>
            {
                new Person
                {
                    Name = "John Anderson",
                    Age = 35,
                    Location = "United State"
                },
                new Person
                {
                    Name = "Philip Xal",
                    Age = 89,
                    Location = "Australia"
                },
                new Person
                {
                    Name = "John Does",
                    Age = 56,
                    Location = "Unknown"
                }
            };
            MainListView.ItemsSource = persons;
        }

        private void MenuItem_Clicked(object sender, EventArgs e)
        {
            var mi = ((MenuItem)sender);
            DisplayAlert("More Action Context", mi.CommandParameter + " more context action", "OK");
        }

        private void MenuItem_Clicked_1(object sender, EventArgs e)
        {
            var mi = ((MenuItem)sender);
            DisplayAlert("Delete Action Context", mi.CommandParameter + " delete context action", "OK");
        }

        private void MainListView_Scrolled(object sender, ScrolledEventArgs e)
        {
            Debug.WriteLine("ScrollX: " + e.ScrollX);
            Debug.WriteLine("ScrollY: " + e.ScrollY);
        }
    }
}