using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using BasicXamarin.BackgroundService.ViewModal;
using Foundation;
using UIKit;
using Xamarin.Forms;

namespace BasicXamarin.iOS.Services
{
    public class iOSLongRunningTaskService
    {
        nint _taskId;
        CancellationTokenSource _cts;
        internal async  Task Start()
        {
            _cts = new CancellationTokenSource();
            _taskId = UIApplication.SharedApplication.BeginBackgroundTask("LongRunningTask", Stop);
            try
            {
                //invoke shared code
                var counter = new TaskCounter();
                await counter.RunCounter(_cts.Token);
            }
            catch (OperationCanceledException) { }
            finally
            {
                if (_cts.IsCancellationRequested)
                {
                    var message = new CancelledMessage();
                    Device.BeginInvokeOnMainThread(() => MessagingCenter.Send(message, "CancelledMessage"));
                }
            }
            UIApplication.SharedApplication.EndBackgroundTask(_taskId);
        }


        internal void Stop()
        {
            _cts.Cancel();
        }
    }
    public class CancelledMessage { }
}