using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BasicXamarin.XAML.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProgressBarControl : ContentPage
    {
        public ProgressBarControl()
        {
            InitializeComponent();
            ProgressBar progressBar = new ProgressBar { Progress = 0.5f };
            Task.Run(async () =>
            {
                //animate progress bar
                await progressBar.ProgressTo(0.75, 500, Easing.Linear);
            });
            Content = new StackLayout
            {
                Margin = new Thickness(5),
                Children =
                {
                    progressBar
                }
            };
        }
    }
}