using BasicXamarin.XAML.Controls.Module;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;

namespace BasicXamarin.XAML.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MapControl : ContentPage
    {
        public MapControl()
        {
            InitializeComponent();
            //Position position = new Position(36.9628066, -122.0194722);
            //MapSpan mapSpan = new MapSpan(position, 0.01, 0.01);
            //Map map = new Map(mapSpan);
            //Content = map;s

            //move the map
            //Position position = new Position(38.285282, -104.629838);
            //MapSpan mapSpan = MapSpan.FromCenterAndRadius(position, Distance.FromKilometers(0.90));
            //map.MoveToRegion(mapSpan);



            //Zoom the map
            //double zoomLevel = 0.3;
            //double latlongDegree = 360 / (Math.Pow(2, zoomLevel));
            //if (map.VisibleRegion == null)
            //{
            //    map.MoveToRegion(new MapSpan(new Position(45.644729, -122.130949), latlongDegree, latlongDegree));
            //}

            // customer map
            //CustomerPin customerPin = new CustomerPin
            //{
            //    Type = PinType.Place,
            //    Position = new Position(37.79752, -122.40183),
            //    Label = "Xamarin San Franscisco Building",
            //    Address = "394 Pacific Ave, San Francisco CA",
            //    Name = "Xamarin",
            //    Url = "http://xamarin.com/about/"
            //};
            //MapCustom.CustomerPins = new List<CustomerPin> { customerPin };
            //MapCustom.Pins.Add(customerPin);
            //MapCustom.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(37.79752, -122.40183), Distance.FromMiles(1.0)));

            //Geocode (get position from address)
            //Xamarin.Forms.Maps.Map map = Task.Run<Xamarin.Forms.Maps.Map>(async () =>
            //{
            //    Geocoder geocoder = new Geocoder();
            //    IEnumerable<Position> approximateLocations = await geocoder.GetPositionsForAddressAsync("Pacific Ave, San Francisco, California");
            //    Position position = approximateLocations.FirstOrDefault();
            //    string coordinates = $"{position.Latitude} {position.Longitude}";
            //    MapSpan mapSpan = new MapSpan(position, 0.01, 0.01);
            //    return new Xamarin.Forms.Maps.Map(mapSpan);
            //}).Result;
            //Content = map;

            //Reverse geocode an address( get address from position)
            //string proxymityAddress = Task.Run<string>(async () =>
            //{
            //    Position position = new Position(37.8044866, -122.4324132);
            //    Geocoder geocoder = new Geocoder();
            //    IEnumerable<string> possibleAddresses = await geocoder.GetAddressesForPositionAsync(position);
            //    string address = possibleAddresses.FirstOrDefault();
            //    return address;
            //}).Result;
            //pos.Text = proxymityAddress;

            // Native Map App
            //Task.Run(async () =>
            //{
            //    if (Device.RuntimePlatform == Device.iOS)
            //    {
            //        await Launcher.OpenAsync("http://maps.apple.com/?q=394+Pacific+Ave+San+Francisco+CA");
            //    }
            //    else if (Device.RuntimePlatform == Device.Android)
            //    {
            //        await Launcher.OpenAsync("geo:0,0?q=394+Pacific+Ave+San+Francisco+CA");
            //    }
            //    else if (Device.RuntimePlatform == Device.UWP)
            //    {
            //        await Launcher.OpenAsync("bingmaps:?where=394 Pacific Ave San Francisco CA");
            //    }
            //});

            //Launche map with direction

            //Task.Run(async () =>
            //{
            //    if (Device.RuntimePlatform == Device.iOS)
            //    {
            //        // https://developer.apple.com/library/ios/featuredarticles/iPhoneURLScheme_Reference/MapLinks/MapLinks.html
            //        await Launcher.OpenAsync("http://maps.apple.com/?daddr=San+Francisco,+CA&saddr=cupertino");
            //    }
            //    else if (Device.RuntimePlatform == Device.Android)
            //    {
            //        // opens the 'task chooser' so the user can pick Maps, Chrome or other mapping app
            //        await Launcher.OpenAsync("http://maps.google.com/?daddr=San+Francisco,+CA&saddr=Mountain+View");
            //    }
            //    else if (Device.RuntimePlatform == Device.UWP)
            //    {
            //        await Launcher.OpenAsync("bingmaps:?rtp=adr.394 Pacific Ave San Francisco CA~adr.One Microsoft Way Redmond WA 98052");
            //    }
            //});


            //Map Polygons and Polylines
            /*
             Polygon and Polyline elements allow you to highlight specific areas on a map. 
             A Polygon is a fully enclosed shape that can have a stroke and fill color. 
             A Polyline is a line that does not fully enclose an area.
             */
            //Position position = new Position(47.6368678, -122.137305);
            //MapSpan mapSpan = new MapSpan(position, 0.01, 0.01);
            //Map map = new Map(mapSpan);
            //Polygon polygon = new Polygon
            //{
            //    StrokeWidth = 8,
            //    StrokeColor = Color.FromHex("#1BA1E2"),
            //    FillColor = Color.FromHex("#881BA1E2"),
            //    Geopath =
            //    {
            //        new Position(47.6368678, -122.137305),
            //        new Position(47.6368894, -122.134655),
            //        new Position(47.6359424, -122.134655),
            //        new Position(47.6359496, -122.1325521),
            //        new Position(47.6424124, -122.1325199),
            //        new Position(47.642463,  -122.1338932),
            //        new Position(47.6406414, -122.1344833),
            //        new Position(47.6384943, -122.1361248),
            //        new Position(47.6372943, -122.1376912)
            //    }
            //};
            //map.MapElements.Add(polygon);
            //Content = map;

            // polyline
            Position position = new Position(47.6368678, -122.137305);
            MapSpan mapSpan = new MapSpan(position, 0.01, 0.01);
            Map map = new Map(mapSpan);
            Polyline polyline = new Polyline
            {
                StrokeWidth = 8,
                StrokeColor = Color.FromHex("#1BA1E2"),
                Geopath =
                {
                    new Position(47.6359496, -122.1325521),
                    new Position(47.6424124, -122.1325199),
                    new Position(47.642463,  -122.1338932),
                    new Position(47.6406414, -122.1344833)
                }
            };
            map.MapElements.Add(polyline);
            Content = map;

        }
        //private void Button_Clicked(object sender, EventArgs e)
        //{
        //    // street
        //    map.MapType = MapType.Street;
        //}

        //private void Button_Clicked_1(object sender, EventArgs e)
        //{
        //    // satellite
        //    map.MapType = MapType.Satellite;
        //}

        //private void Button_Clicked_2(object sender, EventArgs e)
        //{
        //    // Hybride
        //    map.MapType = MapType.Hybrid;
        //}

        //private void map_MapClicked(object sender, MapClickedEventArgs e)
        //{
        //    var position = e.Position;
        //    MapSpan mapSpan = MapSpan.FromCenterAndRadius(position, Distance.FromKilometers(0.80));
        //    map.MoveToRegion(mapSpan);
        //}
    }
}