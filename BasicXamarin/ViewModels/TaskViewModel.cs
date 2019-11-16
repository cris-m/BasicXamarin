using BasicXamarin.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace BasicXamarin.ViewModels
{
    public class TaskViewModel : INotifyPropertyChanged
    {
        private TaskModel task;
        private string message;

        public event PropertyChangedEventHandler PropertyChanged;
        public string Message { get => message;
            set
            {
                message = value;
                OnPropertyChanged();
            }
        }

        public TaskModel Task
        {
            get => task;
            set
            {
                task = value;
                OnPropertyChanged();
            }
        }
        public TaskViewModel()
        {
            Task = new TaskModel()
            {
                Title = "Create UI",
                Duration = 2
            };
        }
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public Command SaveCommand
        {
            get => new Command(() =>
            {
                Message = "Your task " + Task.Title + ", " + Task.Duration + " was successfuly saved";
            });
        }
    }
}
