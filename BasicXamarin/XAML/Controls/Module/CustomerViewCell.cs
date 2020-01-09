using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace BasicXamarin.XAML.Controls.Module
{
    public class CustomerViewCell: ViewCell
    {
        Label name, age, location;
        public static readonly BindableProperty NameProperty = BindableProperty.Create("Name", typeof(string), typeof(CustomerViewCell), "Name");
        public static readonly BindableProperty AgeProperty = BindableProperty.Create("Age", typeof(int), typeof(CustomerViewCell), 0);
        public static readonly BindableProperty LocationProperty = BindableProperty.Create("Location", typeof(string), typeof(CustomerViewCell), "Location");
        public CustomerViewCell()
        {
            var grid = new Grid { Padding = new Thickness(10) };
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(0.5, GridUnitType.Star) });
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(0.2, GridUnitType.Star) });
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(0.3, GridUnitType.Star) });

            name = new Label { FontAttributes = FontAttributes.Bold };
            age = new Label();
            location = new Label { HorizontalTextAlignment = TextAlignment.End };

            grid.Children.Add(name);
            grid.Children.Add(age, 1, 0);
            grid.Children.Add(location, 2, 0);

            View = grid;
        }
        public string Name
        {
            get { return (string)GetValue(NameProperty); }
            set { SetValue(NameProperty, value); }
        }
        public int Age
        {
            get { return (int)GetValue(AgeProperty); }
            set { SetValue(AgeProperty, value); }
        }
        public string Location
        {
            get { return (string)GetValue(LocationProperty); }
            set { SetValue(LocationProperty, value); }
        }

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();
            if (BindingContext != null)
            {
                name.Text = Name;
                age.Text = Age.ToString();
                location.Text = Location;
            }
        }
    }
}
