using BasicXamarin.BackgroundService.ViewModal;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BasicXamarin.BackgroundService
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PersistDataTaskPage : ContentPage
    {
        public static DataViewModal ModalData = new DataViewModal();
        public PersistDataTaskPage()
        {
            InitializeComponent();
            
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            this.BindingContext = ModalData;
        }
        
    }
}