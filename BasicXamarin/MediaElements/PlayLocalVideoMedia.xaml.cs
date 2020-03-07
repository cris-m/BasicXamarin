using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BasicXamarin.MediaElements
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PlayLocalVideoMedia : ContentPage
    {
        public PlayLocalVideoMedia()
        {
            InitializeComponent();
            this.BindingContext = "testvideo.mp4";
        }
        private void MediaElement_MediaFailed(object sender, EventArgs e)
        {
            DisplayAlert("Info", "Media Failed", "OK");
        }

        private void MediaElement_MediaOpened(object sender, EventArgs e)
        {
            DisplayAlert("Info", "Media Opened", "OK");
        }

        private void MediaElement_MediaEnded(object sender, EventArgs e)
        {
            DisplayAlert("Info", "Media Ended", "OK");
        }

        private void MediaElement_SeekCompleted(object sender, EventArgs e)
        {
            DisplayAlert("Info", "Media Seek compleded", "OK");
        }
    }
}