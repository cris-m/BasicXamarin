using BasicXamarin.BackgroundService.Service;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BasicXamarin.BackgroundService
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DownloadTaskPage : ContentPage
    {
        public DownloadTaskPage()
        {
            InitializeComponent();
            MessagingCenter.Subscribe<DownloadProgressMessage>(this, "DownloadProgressMessage", message => {
                Device.BeginInvokeOnMainThread(() => {
                    this.MainLabel.Text = message.Percentage.ToString("P2");
                });
            });

            MessagingCenter.Subscribe<DownloadFinishedMessage>(this, "DownloadFinishedMessage", message => {
                Device.BeginInvokeOnMainThread(() =>
                {
                    this.MainImage.Source = FileImageSource.FromFile(message.FilePath);
                });
            });
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var message = new DownloadMessage
            {
                Url = "https://xamarinuniversity.blob.core.windows.net/ios210/huge_monkey.png"
            };

            MessagingCenter.Send(message, "Download");
        }
    }
}