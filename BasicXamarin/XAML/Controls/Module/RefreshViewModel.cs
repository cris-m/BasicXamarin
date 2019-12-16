using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace BasicXamarin.XAML.Controls.Module
{
    class RefreshViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        const int refreshingDuration = 2;
        bool isRefreshing;
        public ICommand RefreshCommand => new Command(async () =>
        {
            await RefreshItemsAsync();
        });

        private async Task RefreshItemsAsync()
        {
            if(IsRefreshing == true)
            {
                IsRefreshing = false;
                await Task.Delay(TimeSpan.FromSeconds(refreshingDuration));
                IsRefreshing = false;
            }
        }

        public bool IsRefreshing
        {
            get
            {
                return isRefreshing;
            }
            set
            {
                isRefreshing = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("IsRefreshing"));
            }
        }

    }
}
