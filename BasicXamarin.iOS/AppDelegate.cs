using System;
using System.Collections.Generic;
using System.Linq;
using BasicXamarin.BackgroundService.Service;
using BasicXamarin.iOS.Services;
using Foundation;
using UIKit;
using Xamarin.Forms;

namespace BasicXamarin.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        //
        // This method is invoked when the application has loaded and is ready to run. In this 
        // method you should instantiate the window, load the UI into it and then make the window
        // visible.
        //
        // You have 17 seconds to return from this method, or iOS will terminate your application.
        //
        iOSLongRunningTaskService longRunningTaskExample;
        public static Action BackgroundSessionCompletionHandler;
        public override void HandleEventsForBackgroundUrl(UIApplication application, string sessionIdentifier, Action completionHandler)
        {
            Console.WriteLine("HandleEventsForBackgroundUrl(): " + sessionIdentifier);
            // We get a completion handler which we are supposed to call if our transfer is done.
            BackgroundSessionCompletionHandler = completionHandler;
        }
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            #region Long Running Task
            MessagingCenter.Subscribe<StartLongRunningTaskMessage>(this, "StartLongRunningTaskMessage", async message =>
            {
                longRunningTaskExample = new iOSLongRunningTaskService();
                await longRunningTaskExample.Start();
            });
            MessagingCenter.Subscribe<StopLongRunningTaskMessage>(this, "StopLongRunningTaskMessage", message =>
            {
                longRunningTaskExample.Stop();
            });
            #endregion
            #region Download Task Service
            MessagingCenter.Subscribe<DownloadMessage>(this, "Download", async message =>
            {
                var downloader = new Downloader(message.Url);
                await downloader.DownloadFile();
            });
            #endregion

            Xamarin.Forms.Forms.SetFlags(new string[] {
                "SwipeView_Experimental",
                "CarouselView_Experimental",
                "IndicatorView_Experimental"
            });
            Xamarin.FormsMaps.Init();
            global::Xamarin.Forms.Forms.Init();
            global::Xamarin.Forms.FormsMaterial.Init();
            LoadApplication(new App());
            return base.FinishedLaunching(app, options);
        }
    }
}
