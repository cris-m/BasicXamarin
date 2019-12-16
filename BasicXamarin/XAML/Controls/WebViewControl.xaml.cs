using BasicXamarin.XAML.Controls.Module;
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
            //Content = browser;

            // Local HTML file
            var browser = new WebView();
            var htmlSource = new HtmlWebViewSource();
            htmlSource.BaseUrl = DependencyService.Get<IBaseUrl>().Get();
            browser.Source = htmlSource;
            Content = browser;

            //var browser = new WebView();
            //var urlSource = new UrlWebViewSource();
            //string baseUrl = DependencyService.Get<IBaseUrl>().Get();
            //string filePathUrl = Path.Combine(baseUrl, "index.html");
            //urlSource.Url = filePathUrl;
            //browser.Source = urlSource;
            //Content = browser;
        }
    }
}