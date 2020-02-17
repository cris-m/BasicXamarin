using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using BasicXamarin.BackgroundService.Service;
using Xamarin.Forms;

namespace BasicXamarin.Droid.Services
{
    [Service]
    public class DownloaderService : Service
    {
        public override IBinder OnBind(Intent intent)
        {
            return null;
        }
        [return: GeneratedEnum]
        public override StartCommandResult OnStartCommand(Intent intent, [GeneratedEnum] StartCommandFlags flags, int startId)
        {
            var url = intent.GetStringExtra("url");

            Task.Run(() => {
                var imageHelper = new ImageHelper();
                imageHelper.DownloadImageAsync(url)
                        .ContinueWith(filePath => {
                            var message = new DownloadFinishedMessage
                            {
                                FilePath = filePath.Result
                            };
                            MessagingCenter.Send(message, "DownloadFinishedMessage");
                        });
            });

            return StartCommandResult.Sticky;
        }
    }
}