using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BasicXamarin.XAML.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ImageControl : ContentPage
    {
        public ImageControl()
        {
            ////embedded image
            //var embeddedImage = new Image { Aspect = Aspect.AspectFit };

            //embeddedImage.Source = ImageSource.FromResource("BasicXamarin.XAML.Controls.452292672.jpg", typeof(ImageControl).GetTypeInfo().Assembly);
            //Content = new StackLayout
            //{
            //    Children =
            //    {
            //        embeddedImage
            //    }
            //};

            InitializeComponent();
            // download image and display it 
            var webImage = new Image { Source = ImageSource.FromUri(new Uri("https://xamarin.com/content/images/pages/forms/example-app.png")) };

            //Downloaded Image Caching
            /*
             Caching is enabled by default and will store the image locally for 24 hours. To disable caching for a particular image, i
             nstantiate the image source as follows:
             */
            webImage.Source = new UriImageSource { CachingEnabled = false, Uri = new Uri("http://server.com/image") };
            //To set a specific cache period (for example, 5 days) instantiate the image source as follows:
            webImage.Source = new UriImageSource
            {
                Uri = new Uri("https://xamarin.com/content/images/pages/forms/example-app.png"),
                CachingEnabled = true,
                CacheValidity = new TimeSpan(5, 0, 0, 0)
            };

            // NOTE: use for debugging, not in released app code!
            var assembly = typeof(ImageControl).GetTypeInfo().Assembly;
            foreach (var res in assembly.GetManifestResourceNames())
            {
                Console.WriteLine("found resource: " + res);
                Debug.WriteLine("found resource: " + res);
            }

            //var image = new Image
            //{
            //    Source = "https://aka.ms/campus.jpg"
            //};
            // display image basedon platform
            //image.Source = Device.RuntimePlatform == Device.Android ? ImageSource.FromFile("icon.png") : ImageSource.FromFile("icon.png");
        }
    }
}