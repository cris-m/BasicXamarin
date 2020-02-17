using System;
using System.Collections.Generic;
using System.Text;

namespace BasicXamarin.BackgroundService.Service
{
    public class StartLongRunningTaskMessage { }
    public class StopLongRunningTaskMessage { }
    public class TickedMessage
    {
        public string Message { get; set; }
    }
}
