using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BasicXamarin.Essentials
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TextToSpeechPage : ContentPage
    {
        public TextToSpeechPage()
        {
            InitializeComponent();
        }

        private  void Button_Clicked(object sender, EventArgs e)
        {
            //await SpeakNow(MainText.Text);
            //await SpeakNow2(MainText.Text);

            // text to speech with cancelation token
            //await SpeakNow3(MainText.Text);

            // multiple text to speech
            //SpeackMuliple();

            //await SpeakNow();

            speackLanguage();
        }
        async Task SpeakNow(string message)
        {
            //await TextToSpeech.SpeakAsync(message);
            await TextToSpeech.SpeakAsync(message);
        }
        async Task SpeakNow2(string message)
        {
            await TextToSpeech.SpeakAsync(message).ContinueWith((t) =>
            {

                DisplayAlert("Info", "You have said " + message, "OK");
            }, TaskScheduler.FromCurrentSynchronizationContext());
        }
        CancellationTokenSource cts;
        async Task SpeakNow3(string message)
        {
            cts = new CancellationTokenSource();
            await TextToSpeech.SpeakAsync(message, cancelToken: cts.Token);
        }
        public void CancelTextToSpeech()
        {
            if (cts?.IsCancellationRequested ?? true)
                return;
            cts.Cancel();
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            CancelTextToSpeech();
            DisplayAlert("Info", "Text to speech cancel successfuly", "OK");
        }
        public bool isBusy = false;
        public void SpeackMuliple()
        {
            //isBusy = true;
            //Task.Run(async () =>
            //{
            //    await TextToSpeech.SpeakAsync("Hello 1");
            //    await TextToSpeech.SpeakAsync("Hello 2");
            //    await TextToSpeech.SpeakAsync("Hello 3");
            //    await TextToSpeech.SpeakAsync("Hello 4");
            //    isBusy = false;
            //});

            // or you can query multiple without a Task
            Task.WhenAll(
                TextToSpeech.SpeakAsync("Hello 1"),
                TextToSpeech.SpeakAsync("Hello 2"),
                TextToSpeech.SpeakAsync("Hello 3")).ContinueWith((t) =>
                {
                    isBusy = false;
                }, TaskScheduler.FromCurrentSynchronizationContext());
        }

        //Speech Settings
        public async Task SpeakNow()
        {
            var setting = new SpeechOptions()
            {
                Volume = .75f,
                Pitch = 1.5f
            };
            await TextToSpeech.SpeakAsync("Hello world", setting);
        }

        //Speech Locales. it take the language of the device
        public async Task speackLanguage()
        {
            //get the device language
            var locales = await TextToSpeech.GetLocalesAsync();
            //Grab the first locale
            var locale = locales.FirstOrDefault();
            var settings = new SpeechOptions
            {
                Volume = .75f,
                Pitch = 1.2f,
                Locale = locale
            };
            await TextToSpeech.SpeakAsync("Hello world", settings);
        }
    }
}