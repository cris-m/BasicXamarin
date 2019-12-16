using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using BasicXamarin.iOS;
using BasicXamarin.XAML.Controls.Module;
using Foundation;
using UIKit;

[assembly: Xamarin.Forms.Dependency(typeof(BaseUrl_iOS))]
namespace BasicXamarin.iOS
{
    public class BaseUrl_iOS : IBaseUrl
    {
        public string Get()
        {
            return NSBundle.MainBundle.BuiltinPluginsPath;
        }
    }
}