using System;
using System.Collections.Generic;
using System.Text;

namespace BasicXamarin.BackgroundService.Service
{
    public class DownloadProgressMessage
    {
        public long BytesWritten { get; set; }

        public long TotalBytesWritten { get; set; }

        public long TotalBytesExpectedToWrite { get; set; }

        public float Percentage { get; set; }
    }
}
