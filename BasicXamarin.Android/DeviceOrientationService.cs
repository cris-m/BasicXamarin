using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using BasicXamarin.DependencyServices;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

[assembly:Dependency(typeof(Dependecy.Droid.DeviceOrientationService))]
namespace Dependecy.Droid
{
    public class DeviceOrientationService : IDeviceOrientationService
    {
        public DeviceOrientation GetDeviceOrientation()
        {
            IWindowManager windowManager = Android.App.Application.Context.GetSystemService(Context.WindowService).JavaCast<IWindowManager>();
            SurfaceOrientation orientation = windowManager.DefaultDisplay.Rotation;
            bool isLandScape = orientation == SurfaceOrientation.Rotation90 || orientation == SurfaceOrientation.Rotation270;
            return isLandScape ? DeviceOrientation.Landscape : DeviceOrientation.Portrait;
        }
    }
}