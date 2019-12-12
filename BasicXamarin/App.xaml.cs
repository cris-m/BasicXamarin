using BasicXamarin.Essentials;
using BasicXamarin.GetStarted;
using BasicXamarin.GetStarted.Models;
using BasicXamarin.XAML;
using BasicXamarin.XAML.Controls;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BasicXamarin
{
    public partial class App : Application
    {
        public static string FolderPath { get; private set; }
        static NoteDatabase db;
        public static NoteDatabase DB
        {
            get
            {
                if (db == null)
                {
                    db = new NoteDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Notes.db3"));
                }
                return db;
            }
        }
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
            //MainPage = new OnPlatforms();
            //MainPage = new Alerts();
            //MainPage = new ActionMenus();
            //MainPage = new SliderControl();
            //MainPage = new XReference();
            //MainPage = new DatepickerControl();
            //MainPage = new Switchs();
            //MainPage = new Progressbars();
            //MainPage = new NavigationPage(new ToolBars());
            //MainPage = new SearchbarControl();
            //MainPage = new Pickers();

            //**** Get started**********
            //MainPage = new SinglePage();
            //FolderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData));
            //MainPage = new NavigationPage(new MultiplePage());

            //MainPage = new NavigationPage(new DatabasePage());
            //MainPage = new StylesPage();

            //**** XAML *******************
            //MainPage = new XamlIntroduction();
            //MainPage = new XamlMarkup();
            //MainPage = new XamlDataBinding();
            //MainPage = new FormDataBinding();
            //MainPage = new XamlCommand();
            //MainPage = new NavigationPage( new NavigationMenu());
            //MainPage = new BoxViewControl();
            //MainPage = new ImageControl();
            //MainPage = new LabelControl();
            //MainPage = new MapControl();
            MainPage = new WebViewControl();

            //****** Xamarin Essentials****
            //MainPage = new AccelerometerPage();
            //MainPage = new AppInfoPage();
            //MainPage = new BarometerPage();
            //MainPage = new BatteryPage();
            //MainPage = new NavigationPage(new LoginClipboard());
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
