using BasicXamarin.XAML.Controls.Module;
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
    public partial class CarouselViewControl : ContentPage
    {
        public CarouselViewControl()
        {
            InitializeComponent();
            //CarouselView carouselView = new CarouselView();
            //carouselView.ItemsSource = new string[]
            //{
            //    "Baboon",
            //    "Capuchin Monkey",
            //    "Blue Monkey",
            //    "Squirrel Monkey",
            //    "Golden Lion Tamarin",
            //    "Howler Monkey",
            //    "Japanese Macaque"
            //};
            //Content = carouselView;

            //Data binding
            //CarouselView carouselView = new CarouselView();
            //carouselView.SetBinding(ItemsView.ItemsSourceProperty, "Monkeys");
        }

        private void carouselView_CurrentItemChanged(object sender, CurrentItemChangedEventArgs e)
        {
            Monkey previousItem = e.PreviousItem as Monkey;
            Monkey currentItem = e.CurrentItem as Monkey;
        }
        private void ToggleEmptyView(bool isToggled)
        {
            MainCarousel.EmptyView = isToggled ? Resources["BasicEmptyView"] : Resources["AdvancedEmptyView"];
        }
        private void Switch_Toggled(object sender, ToggledEventArgs e)
        {
            ToggleEmptyView(e.Value);
        }
    }
}