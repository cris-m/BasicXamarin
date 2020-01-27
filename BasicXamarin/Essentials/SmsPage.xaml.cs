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
    public partial class SmsPage : ContentPage
    {
        public SmsPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await SendSMSAsync(MainText.Text, "+12102880467");
        }
        async Task SendSMSAsync(string message, string number)
        {
            try
            {
                var sms = new SmsMessage(message, new [] { number });
                await Sms.ComposeAsync(sms);
            }
            catch(FeatureNotSupportedException)
            {

            }
            catch (Exception)
            {

            }
        }
    }
}