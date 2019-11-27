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
    public partial class NotePageDatabase : ContentPage
    {
        public NotePageDatabase()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(MainEditor.Text))
            {
                var note = (NoteTable)BindingContext;
                note.Date = DateTime.UtcNow;
                note.Text = MainEditor.Text;

                await App.DB.SaveNoteAsync(note);
                await Navigation.PopAsync();

            }
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            var note = (NoteTable)BindingContext;
            if(note != null)
            {
                await App.DB.DeleteNoteAsync(note);
                await Navigation.PopAsync();
            }
        }
    }
}