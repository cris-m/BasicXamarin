using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BasicXamarin.BackgroundService.Service;
using Foundation;
using UIKit;
using Xamarin.Forms;

namespace BasicXamarin.iOS.Services
{
    public class CustomSessionDownloadDelegate : NSUrlSessionDownloadDelegate
    {
        private string targetFilename;

        public CustomSessionDownloadDelegate(string targetFilename):base()
        {
            this.targetFilename = targetFilename;
        }

        public override void DidWriteData(NSUrlSession session, NSUrlSessionDownloadTask downloadTask, long bytesWritten, long totalBytesWritten, long totalBytesExpectedToWrite)
        {
            //base.DidWriteData(session, downloadTask, bytesWritten, totalBytesWritten, totalBytesExpectedToWrite);
            float percentage = (float)totalBytesWritten / (float)totalBytesExpectedToWrite;
            var message = new DownloadProgressMessage()
            {
                BytesWritten = bytesWritten,
                TotalBytesExpectedToWrite = totalBytesExpectedToWrite,
                TotalBytesWritten = totalBytesWritten,
                Percentage = percentage
            };
            MessagingCenter.Send<DownloadProgressMessage>(message, "DownloadProgressMessage");
        }
        public override void DidFinishDownloading(NSUrlSession session, NSUrlSessionDownloadTask downloadTask, NSUrl location)
        {
            CopyDownloadedImage(location);
            var message = new DownloadFinishedMessage()
            {
                FilePath = targetFilename,
                Url = downloadTask.OriginalRequest.Url.AbsoluteString
            };
            MessagingCenter.Send<DownloadFinishedMessage>(message, "DownloadFinishedMessage");
        }

        public override void DidFinishEventsForBackgroundSession(NSUrlSession session)
        {
            var handler = AppDelegate.BackgroundSessionCompletionHandler;
            AppDelegate.BackgroundSessionCompletionHandler = null;
            if (handler != null)
            {
                handler.Invoke();
            }
        }
        private void CopyDownloadedImage(NSUrl location)
        {
            NSFileManager fileManager = NSFileManager.DefaultManager;
            NSError error;
            if (fileManager.FileExists(targetFilename))
            {
                fileManager.Remove(targetFilename, out error);
            }
            bool success = fileManager.Copy(location.Path, targetFilename, out error);
            if (success)
            {
                Console.WriteLine("Error during the copy: {0}", error.LocalizedDescription);
            }
        }
    }
    public class DownloadProgressMessage
    {
        public long BytesWritten { get; internal set; }
        public long TotalBytesExpectedToWrite { get; internal set; }
        public long TotalBytesWritten { get; internal set; }
        public float Percentage { get; internal set; }
    }
}