using BasicXamarin.GetStarted.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BasicXamarin.GetStarted
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MultiplePage : ContentPage
    {
        public MultiplePage()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            var notes = new List<Note>();
            var files = Directory.EnumerateFiles(App.FolderPath, "*.notes.txt");
            foreach(var filename in files)
            {
                notes.Add(new Note
                {
                    FileName = filename,
                    Text = File.ReadAllText(filename),
                    Date = File.GetCreationTime(filename)
                });
            }
            MainListView.ItemsSource = notes.OrderBy(d => d.Date).ToList();
        }

        private async void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NotePage
            {
                BindingContext = new Note()
            });
        }

        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if(e.SelectedItem != null)
            {
                await Navigation.PushAsync(new NotePage
                {
                    BindingContext = e.SelectedItem as Note
                });
            }
        }
    }
}