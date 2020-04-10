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
using BasicXamarin.Droid.Extensions;
using BasicXamarin.Essentials.Service;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms.Platform.Android.AppCompat;

namespace BasicXamarin.Droid.Renderers
{
    public class CustomNavigationPageRenderer: NavigationPageRenderer
    {
         Toolbar modalToolbar;

        public CustomNavigationPageRenderer(Context context) : base(context)
        {
        }

        protected override void OnAttachedToWindow()
        {
            base.OnAttachedToWindow();

            if (Element.CurrentPage is IModalPage)
            {
                var activity = Context as FormsAppCompatActivity;
                var content = activity.FindViewById(Android.Resource.Id.Content) as ViewGroup;
                var toolbars = content.GetChildrenOfType<Toolbar>();

                modalToolbar = toolbars.Last();
                //modalToolbar.NavigationClick += OnModalToolbarNavigationClick;
                modalToolbar.NavigationOnClick += ModalToolbar_NavigationOnClick;
            }
        }

        private void ModalToolbar_NavigationOnClick(object sender, EventArgs e)
        {
            if (Element.CurrentPage is IModalPage modalPage)
                modalPage.Dismiss();
            else
                Element.SendBackButtonPressed();
        }

        protected override void OnDetachedFromWindow()
        {
            base.OnDetachedFromWindow();

            if (modalToolbar != null)
            {
                modalToolbar.NavigationOnClick -= ModalToolbar_NavigationOnClick;
                //modalToolbar.NavigationClick -= OnModalToolbarNavigationClick;
            }
        }

        protected override void OnLayout(bool changed, int l, int t, int r, int b)
        {
            base.OnLayout(changed, l, t, r, b);

            if (Element.CurrentPage is IModalPage)
            {
                modalToolbar?.SetNavigationIcon(Resource.Drawable.ic_mtrl_chip_close_circle);
                //                    .ic_dialog_close_dark);
            }
        }

        //void OnModalToolbarNavigationClick(object sender, Toolbar.NavigationClickEventArgs e)
        //{
        //    if (Element.CurrentPage is IModalPage modalPage)
        //        modalPage.Dismiss();
        //    else
        //        Element.SendBackButtonPressed();
        //}
    }
}