using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace BasicXamarin.DependencyServices
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DependencyServicesPage : TabbedPage
    {
        public DependencyServicesPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            DeviceOrientation deviceOrientation = DependencyService.Get<IDeviceOrientationService>().GetDeviceOrientation();
            MainText.Text = deviceOrientation.ToString();
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            (sender as Button).IsEnabled = false;
            Stream stream = await DependencyService.Get<IPhotoPickerServices>().GetImageStreamAsync();
            if(stream != null)
            {
                MainImage.Source = ImageSource.FromStream(()=> stream);
            }
            (sender as Button).IsEnabled = true;
        }
    }
}