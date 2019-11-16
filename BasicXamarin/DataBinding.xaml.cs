﻿using BasicXamarin.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BasicXamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DataBinding : ContentPage
    {
        public DataBinding()
        {
            InitializeComponent();
            BindingContext = new TaskViewModel();
        }
    }
}