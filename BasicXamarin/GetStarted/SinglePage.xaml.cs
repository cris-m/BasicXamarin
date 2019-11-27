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
    public partial class SinglePage : ContentPage
    {
        string filename = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "note.txt");
        public SinglePage()
        {
            InitializeComponent();
            if (File.Exists(filename))
            {
                MainEditor.Text = File.ReadAllText(filename);
            }
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            File.WriteAllText(filename, MainEditor.Text);
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            MainEditor.Text = string.Empty;
        }
    }
}