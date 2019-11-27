using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BasicXamarin.Essentials
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AppInfoPage : ContentPage
    {
        public AppInfoPage()
        {
            InitializeComponent();
            // Get App information
            var appName = AppInfo.Name;
            var packageName = AppInfo.PackageName;
            var version = AppInfo.VersionString;
            var buildNumber = AppInfo.BuildString;

            MainLabel.Text = $"App Name: {appName}\nPackage Name: {packageName}\n Version: {version}\nBuild Number: {buildNumber}";
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            AppInfo.ShowSettingsUI();
        }
    }
}