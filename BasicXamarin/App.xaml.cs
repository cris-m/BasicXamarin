using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BasicXamarin
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();

            //MainPage = new LabelButtonEntry();

            //MainPage = new UIProperties();

            //MainPage = new NavigationPage(new Page1Navigation());

            //MainPage = new TabbedPage
            //{
            //    Children =
            //    {
            //        new Page1Tab(),
            //        new Page2Tab()
            //    }
            //};

            //MainPage = new CarouselPage
            //{
            //    Children =
            //    {
            //        new Page1Tab(),
            //        new Page2Tab()
            //    }
            //};

            //MainPage = new ListViews();
            //MainPage = new MasterDetailPages();
            //MainPage = new Styles();
            //MainPage = new DataBinding();
            //MainPage = new Converters();
            MainPage = new OnPlatforms();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
