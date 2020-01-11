using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BasicXamarin.Essentials
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SharePage : ContentPage
    {
        public SharePage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            //await ShareText("This is some text to share");
            //await ShareUri("https://duckduckgo.com");
            await ShareFile();

        }
        public async Task ShareText(string text)
        {
            await Share.RequestAsync(new ShareTextRequest
            {
                Text = text,
                Title = "Share text"
            });
        }
        public async Task ShareUri(string uri)
        {
            await Share.RequestAsync(new ShareTextRequest
            {
                Text = uri,
                Title = "Share Web Link"
            });
        }
        public async Task ShareFile()
        {
            var file = "ReadMe.txt";
            var path = Path.Combine(FileSystem.CacheDirectory, file);
            File.WriteAllText(path, "This is for test purpose");
            await Share.RequestAsync(new ShareFileRequest
            {
                Title = "Share Web Link",
                File = new ShareFile(path)
            });
        }
    }
}