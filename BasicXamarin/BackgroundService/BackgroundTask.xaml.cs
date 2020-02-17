using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BasicXamarin.BackgroundService
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BackgroundTask : TabbedPage
    {
        public BackgroundTask()
        {
            InitializeComponent();
        }
    }
}