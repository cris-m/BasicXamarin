﻿using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms.Internals;

namespace BasicXamarin.DependencyServices
{
    public interface IDeviceOrientationService
    {
        DeviceOrientation GetDeviceOrientation();
    }
}
