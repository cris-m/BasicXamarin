using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BasicXamarin.Essentials.Service;
using Foundation;
using UIKit;
using Xamarin.Forms.Platform.iOS;

namespace BasicXamarin.iOS.Renderers
{
    public class CustomPageRenderer: PageRenderer
    {
        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);

            if (Element is IModalPage modalPage)
            {
                NavigationController.TopViewController.NavigationItem.LeftBarButtonItem =
                    new UIBarButtonItem("Cancel", UIBarButtonItemStyle.Plain, (s, e) => modalPage.Dismiss());
            }
        }
    }
}