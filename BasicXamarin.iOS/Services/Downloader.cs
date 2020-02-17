using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Foundation;
using UIKit;

namespace BasicXamarin.iOS.Services
{
    public class Downloader
    {
        private string targetFilename = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "huge_monkey.png");

        private const string sessionId = "com.companyname.basicxamarin";

        private NSUrlSession session;

        readonly string _downloadFileUrl;

        public Downloader(string downloadFileUrl)
        {
            this._downloadFileUrl = downloadFileUrl;
        }

        internal async  Task DownloadFile()
        {
            this.InitializeSession();

            var pendingTasks = await this.session.GetTasks2Async();
            if (pendingTasks != null && pendingTasks.DownloadTasks != null)
            {
                foreach (var task in pendingTasks.DownloadTasks)
                {
                    task.Cancel();
                }
            }
            if (File.Exists(targetFilename))
            {
                File.Delete(targetFilename);
            }
            this.EnqueueDownload();
        }
        private void InitializeSession()
        {
            using(var sessionConfig = UIDevice.CurrentDevice.CheckSystemVersion(8, 0)
                ?NSUrlSessionConfiguration.CreateBackgroundSessionConfiguration(sessionId)
                : NSUrlSessionConfiguration.BackgroundSessionConfiguration(sessionId))
            {
                sessionConfig.AllowsCellularAccess = true;
                sessionConfig.NetworkServiceType = NSUrlRequestNetworkServiceType.Default;
                sessionConfig.HttpMaximumConnectionsPerHost = 2;
                var sessionDelegate = new CustomSessionDownloadDelegate(targetFilename);
                this.session = NSUrlSession.FromConfiguration(sessionConfig, sessionDelegate as INSUrlSessionDelegate, new NSOperationQueue());
            }
        }
        private void EnqueueDownload()
        {
            var downloadTask = this.session.CreateDownloadTask(NSUrl.FromString(_downloadFileUrl));
            if(downloadTask == null)
            {
                var alert = UIAlertController.Create(string.Empty, "Failed to create download task! Please retry.", UIAlertControllerStyle.Alert);
                alert.AddAction(UIAlertAction.Create("OK", UIAlertActionStyle.Default, (alertAction) =>
                {
                    alertAction.Dispose();
                    alert.Dispose();
                }));
                ((AppDelegate)(UIApplication.SharedApplication.Delegate)).Window.RootViewController.PresentViewController(alert, true, null);
            }
            downloadTask.Resume();
        }
    }
}