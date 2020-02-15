using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using BasicXamarin.DependencyServices;
using Xamarin.Forms.Internals;
using Xamarin.Forms;

[assembly: Dependency(typeof(Dependecy.ios.DeviceOrientationService))]
namespace Dependecy.ios
{
    public class DeviceOrientationService : IDeviceOrientationService
    {
        public DeviceOrientation GetDeviceOrientation()
        {
            UIInterfaceOrientation orientation = UIApplication.SharedApplication.StatusBarOrientation;
            bool isPortrait = orientation == UIInterfaceOrientation.Portrait || orientation == UIInterfaceOrientation.PortraitUpsideDown;
            return isPortrait ? DeviceOrientation.Portrait : DeviceOrientation.Landscape;
        }
    }
}