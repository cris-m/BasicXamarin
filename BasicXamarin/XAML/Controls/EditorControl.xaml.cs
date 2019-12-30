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
    public partial class EditorControl : ContentPage
    {
        public EditorControl()
        {
            InitializeComponent();
            //var MainEditor = new Editor { Text = "I am an Editor" };
            //MainEditor.Keyboard = Keyboard.Create(KeyboardFlags.Suggestions | KeyboardFlags.CapitalizeCharacter);
            //Content = new StackLayout()
            //{
            //    Children =
            //    {
            //        MainEditor
            //    }
            //};
        }

        private void Editor_TextChanged(object sender, TextChangedEventArgs e)
        {
            var oldText = e.OldTextValue;
            var newText = e.NewTextValue;
        }

        private void Editor_Completed(object sender, EventArgs e)
        {
            var text = ((Editor)sender).Text;
        }
    }
}