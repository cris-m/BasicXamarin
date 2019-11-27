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
    public partial class NotePage : ContentPage
    {
        public NotePage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var note = (Note)BindingContext;

            if (string.IsNullOrWhiteSpace(note.FileName))
            {
                // Save
                var filename = Path.Combine(App.FolderPath, $"{Path.GetRandomFileName()}.notes.txt");
                File.WriteAllText(filename, note.Text);
            }
            else
            {
                // Update file
                File.WriteAllText(note.FileName, MainEditor.Text);
            }
            await Navigation.PushAsync(new MultiplePage());
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            var note = (Note)BindingContext;
            if (File.Exists(note.FileName))
            {
                File.Delete(note.FileName);
            }
            await Navigation.PopAsync();
        }
    }
}