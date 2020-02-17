using System;
using System.Collections.Generic;
using System.Text;

namespace BasicXamarin.BackgroundService.Service
{
    public class DownloadFinishedMessage
    {
        public string Url { get; set; }

        public string FilePath { get; set; }
    }
}
