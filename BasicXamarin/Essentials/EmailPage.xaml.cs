using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BasicXamarin.Essentials
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EmailPage : ContentPage
    {
        public EmailPage()
        {
            InitializeComponent();
        }
        public async Task SendEmail(string subject, string body, List<string> recipients)
        {
            //try
            //{
            //    var message = new EmailMessage
            //    {
            //        Subject = subject,
            //        Body = body,
            //        To = recipients,
            //        //Cc = ccRecipients,
            //        //Bcc = bccRecipients
            //    };
            //    await Email.ComposeAsync(message);
            //}
            //catch (FeatureNotSupportedException)
            //{

            //}
            //catch (Exception)
            //{

            //}

            // File Attachments
            var message = new EmailMessage
            {
                Subject = "Hello",
                Body = "World",
                To = recipients,
            };
            var fn = "Attachment.txt";
            var file = Path.Combine(FileSystem.CacheDirectory, fn);
            File.WriteAllText(fn, "Hello world");

            message.Attachments.Add(new EmailAttachment(file));
            await Email.ComposeAsync(message);
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            List<string> users = new List<string>
            {
                "user1@mail.com",
                "user2@mail.com"
            };
            Task.Run(async () =>
            {
                await SendEmail("Here is my subject", "This is a message", users);
            });
        }
    }
}
     