using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BasicXamarin.BackgroundService.ViewModal
{
    public class DataViewModal : INotifyPropertyChanged
    {
        private string firstname;
        private DateTime date;

        public DateTime Date
        {
            get { return date; }
            set
            {
                if (date != value)
                {
                    date = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("date"));
                }
            }
        }

        public string Firstname
        {
            get { return firstname; }
            set
            {
                if (firstname != value)
                {
                    firstname = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("fistname"));
                }
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
