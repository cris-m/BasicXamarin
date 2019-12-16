using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace BasicXamarin.XAML.Controls.Module
{
    class CommandInterface : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private int clicked = 0;

        public ICommand OnButtonCliked { private set; get; }
        public CommandInterface()
        {
            //OnButtonCliked = new Command(() =>
            //{
            //    Clicked++;
            //});
            OnButtonCliked = new Command(
                execute: () =>
                {
                    Clicked++;
                },
                canExecute:() => Clicked < 10);
        }
        public int Clicked
        {
            get
            {
                return clicked;
            }
            set
            {
                if(clicked != value)
                {
                    clicked = value;
                    //OnPropertyChanged("Clicked");
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Clicked"));
                    ((Command)OnButtonCliked).ChangeCanExecute();
                }
            }
        }
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
