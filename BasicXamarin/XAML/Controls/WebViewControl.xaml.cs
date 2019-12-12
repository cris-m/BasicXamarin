using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BasicXamarin.XAML.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WebViewControl : ContentPage
    {
        public WebViewControl()
        {
            InitializeComponent();
            //var browser = new WebView
            //{
            //    Source = "http://xamarin.com"
            //};

            // Html
            //var browser = new WebView();
            //var htmlSource = new HtmlWebViewSource();
            //htmlSource.Html = @"
            //    <html>
            //       <body>
            //           <h1>Hello Xamarin Forms</h1>
            //           <p>Welcome to WebView</p>
            //       </body>
            //    </html>";
            //browser.Source = htmlSource;


            //Html fromlocalfile
            var cacheFile = Path.Combine(FileSystem.CacheDirectory, "index.html");
            if (File.Exists(cacheFile))
                File.Delete(cacheFile);
            using (var resource = Assembly.GetExecutingAssembly().GetManifestResourceStream("index.html"))
            using (var file = new FileStream(cacheFile, FileMode.Open, FileAccess.Read))
            {
                resource.CopyTo(file);
                //StreamReader reader = new StreamReader(resource);
                //xx.Text = reader.ReadToEnd();
                //var browser = new WebView();
                //var htmlSource = new HtmlWebViewSource();
                //htmlSource.Html = reader.ReadToEnd();
                //browser.Source = htmlSource;
                //Content = browser;
            }
            string x =  File.ReadAllText("file://localhost/" + cacheFile);
        }
    }
}