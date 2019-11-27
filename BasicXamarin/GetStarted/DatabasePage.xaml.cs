using BasicXamarin.GetStarted.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BasicXamarin.GetStarted
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DatabasePage : ContentPage
    {
        public DatabasePage()
        {
            InitializeComponent();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            MainListView.ItemsSource = await App.DB.GetNotesAsync();
        }

        private async void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NotePageDatabase
            {
                BindingContext = new NoteTable()
            });
        }

        private async void MainListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if(e.SelectedItem != null)
            {
                await Navigation.PushAsync(new NotePageDatabase
                {
                    BindingContext = e.SelectedItem as NoteTable
                }); ;
            }
        }
    }
}