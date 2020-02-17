using BasicXamarin.BackgroundService.Service;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BasicXamarin.BackgroundService
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LongRunningTaskPage : ContentPage
    {
        public LongRunningTaskPage()
        {
            InitializeComponent();
            HandleReceivedMessages();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var message = new StartLongRunningTaskMessage();
            MessagingCenter.Send(message, "StartLongRunningTaskMessage");
        }
        private void Button_Clicked_1(object sender, EventArgs e)
        {
            var message = new StopLongRunningTaskMessage();
            MessagingCenter.Send(message, "StopLongRunningTaskMessage");
        }
        public void HandleReceivedMessages()
        {
            MessagingCenter.Subscribe<TickedMessage>(this, "TickedMessage", message =>
            {
                Device.BeginInvokeOnMainThread(() =>
                {
                    MainLabel.Text = message.Message;
                });
            });
            MessagingCenter.Subscribe<TickedMessage>(this, "CancelledMessage", message =>
            {
                Device.BeginInvokeOnMainThread(() =>
                {
                    MainLabel.Text = message.Message;
                });
            });
        }
    }
}