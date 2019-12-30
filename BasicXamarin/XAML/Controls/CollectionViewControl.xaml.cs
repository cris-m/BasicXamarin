using BasicXamarin.XAML.Controls.Module;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BasicXamarin.XAML.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CollectionViewControl : ContentPage
    {
        public CollectionViewControl()
        {
            InitializeComponent();
            //Scroll an item at an index into view
            //MainCollectView.ScrollTo(12);
            //MainCollectView.ScrollTo(2, 1);

            //Scroll an item into view
            //MonkeyViewModel viewModel = BindingContext as MonkeyViewModel;
            //Monkey monkey = viewModel.Monkeys.FirstOrDefault(m => m.Name == "Proboscis Monkey");
            //MainCollectView.ScrollTo(monkey);

            //Disable scroll animation
            //MainCollectView.ScrollTo(monkey, animate: false);

            //Control scroll position
            //MainCollectView.ScrollTo(monkey, position: ScrollToPosition.MakeVisible);
            //MainCollectView.ScrollTo(monkey, position: ScrollToPosition.Start);
            //MainCollectView.ScrollTo(monkey, position: ScrollToPosition.Center);
            //MainCollectView.ScrollTo(monkey, position: ScrollToPosition.End);

            //Control scroll position when new items are added

            //grouping
            BindingContext = new GroupedAnimalsViewModel(true);
        }

        private void MainCollectionView_RemainingItemsThresholdReached(object sender, EventArgs e)
        {
            //DisplayAlert("Info", "Threshold Reached", "Ok");
        }

        private void OnImageTapped(object sender, EventArgs e)
        {
            Image image = sender as Image;
            image.HeightRequest = image.WidthRequest = image.HeightRequest.Equals(60) ? 100 : 60;
        }

        private void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string previous = (e.PreviousSelection.FirstOrDefault() as Monkey)?.Name;
            string current = (e.CurrentSelection.FirstOrDefault() as Monkey)?.Name;
        }
        //void ToggleEmptyView(bool isToggled)
        //{
        //    collectionView.EmptyView = isToggled ? Resources["BasicEmptyView"] : Resources["AdvancedEmptyView"];
        //}

        //private void Switch_Toggled(object sender, ToggledEventArgs e)
        //{
        //    bool isToggle = e.Value;
        //    ToggleEmptyView(isToggle);
        //}

        private void CollectionView_Scrolled(object sender, ItemsViewScrolledEventArgs e)
        {
            Debug.WriteLine("HorizontalDelta: " + e.HorizontalDelta);
            Debug.WriteLine("VerticalDelta: " + e.VerticalDelta);
            Debug.WriteLine("HorizontalOffset: " + e.HorizontalOffset);
            Debug.WriteLine("VerticalOffset: " + e.VerticalOffset);
            Debug.WriteLine("FirstVisibleItemIndex: " + e.FirstVisibleItemIndex);
            Debug.WriteLine("CenterItemIndex: " + e.CenterItemIndex);
            Debug.WriteLine("LastVisibleItemIndex: " + e.LastVisibleItemIndex);
        }
    }
}