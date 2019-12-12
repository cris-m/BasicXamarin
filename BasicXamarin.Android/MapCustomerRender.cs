using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Gms.Maps;
using Android.Gms.Maps.Model;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using BasicXamarin.Droid;
using BasicXamarin.XAML.Controls.Module;
using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Maps.Android;
using Xamarin.Forms.Platform.Android;

[assembly:ExportRenderer(typeof(CustomerMap), typeof(MapCustomerRender))]
namespace BasicXamarin.Droid
{
    class MapCustomerRender : MapRenderer, GoogleMap.IInfoWindowAdapter
    {
        List<CustomerPin> customerPins;
        public MapCustomerRender(Context context):base(context)
        {

        }

        public Android.Views.View GetInfoContents(Marker marker)
        {
            return null;
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Map> e)
        {
            base.OnElementChanged(e);
            if(e.OldElement != null)
            {
                NativeMap.InfoWindowClick -= OnInfoWindowClick;
            }
            if(e.NewElement != null)
            {
                var formsMap = (CustomerMap)e.NewElement;
                customerPins = formsMap.CustomerPins;
            }
        }
        protected override void OnMapReady(GoogleMap map)
        {
            base.OnMapReady(map);
            NativeMap.InfoWindowClick += OnInfoWindowClick;
            NativeMap.SetInfoWindowAdapter(this);
        }

        private void OnInfoWindowClick(object sender, GoogleMap.InfoWindowClickEventArgs e)
        {
            var customerPin = GetCustomerPin(e.Marker);
            if(customerPin != null)
            {
                throw new Exception("Custom Pin not found");
            }
            if (!string.IsNullOrWhiteSpace(customerPin.Url))
            {
                var url = Android.Net.Uri.Parse(customerPin.Url);
                var intent = new Intent(Intent.ActionView, url);
                intent.AddFlags(ActivityFlags.NewTask);
                Android.App.Application.Context.StartActivity(intent);
            }
        }

        protected override MarkerOptions CreateMarker(Pin pin)
        {
            var marker = new MarkerOptions();
            marker.SetPosition(new LatLng(pin.Position.Latitude, pin.Position.Longitude));
            marker.SetTitle(pin.Label);
            marker.SetSnippet(pin.Address);
            marker.SetIcon(BitmapDescriptorFactory.FromResource(Resource.Mipmap.pin));
            return marker;
        }

        private CustomerPin GetCustomerPin(Marker marker)
        {
            var position = new Position(marker.Position.Latitude, marker.Position.Longitude);
            foreach (var pin in customerPins)
            {
                if (pin.Position == position)
                {
                    return pin;
                }
            }
            return null;
        }

        public Android.Views.View GetInfoWindow(Marker marker)
        {
            var inflater = Android.App.Application.Context.GetSystemService(Context.LayoutInflaterService) as Android.Views.LayoutInflater;
            if (inflater != null)
            {
                Android.Views.View view;
                var customerPin = GetCustomerPin(marker);
                if (customerPin == null)
                {
                    throw new Exception("Customer Pin not found");
                }
                if (customerPin.Name.Equals("Xamarin"))
                {
                    view = inflater.Inflate(Resource.Layout.XamarinMapInfoWindow, null);
                }
                else
                {
                    view = inflater.Inflate(Resource.Layout.MapInfoWindow, null);
                }
                var infoTitle = view.FindViewById<TextView>(Resource.Id.InfoWindowTitle);
                var infoSubtitle = view.FindViewById<TextView>(Resource.Id.InfoWindowSubtitle);
                if (infoTitle != null)
                {
                    infoTitle.Text = marker.Title;
                }
                if (infoSubtitle != null)
                {
                    infoSubtitle.Text = marker.Snippet;
                }

                return view;
            }
            return null;
        }
    }
}