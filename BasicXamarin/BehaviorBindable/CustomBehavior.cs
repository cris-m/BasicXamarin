using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace BasicXamarin.BehaviorBindable
{
    //public class NumericValidationBehavior : Behavior<Entry>
    //{
    //    protected override void OnAttachedTo(Entry entry)
    //    {
    //        entry.TextChanged += Entry_TextChanged;
    //        base.OnAttachedTo(entry);
    //        // Perform setup

    //    }
    //    protected override void OnDetachingFrom(Entry entry)
    //    {
    //        entry.TextChanged -= Entry_TextChanged;
    //        base.OnDetachingFrom(entry);
    //        // Perform setup
    //    }
    //    private void Entry_TextChanged(object sender, TextChangedEventArgs e)
    //    {
    //        double result;
    //        bool isValid = double.TryParse(e.NewTextValue, out result);
    //        ((Entry)sender).TextColor = isValid ? Color.Default : Color.Red;
    //    }
    //}



    // Consuming a Xamarin.Forms Behavior with a Styles
    public class NumericValidationBehavior: Behavior<Entry>
    {
        public static readonly BindableProperty AttachBehaviorProperty =
            BindableProperty.CreateAttached("AttachBehavior", typeof(bool), typeof(NumericValidationBehavior), false, propertyChanged: OnAttachBehaviorChanged);

        public static bool GetAttachBehavior(BindableObject view)
        {
            return (bool)view.GetValue(AttachBehaviorProperty);
        }

        public static void SetAttachBehavior(BindableObject view, bool value)
        {
            view.SetValue(AttachBehaviorProperty, value);
        }
        static void OnAttachBehaviorChanged(BindableObject view, object oldValue, object newValue)
        {
            var entry = view as Entry;
            if (entry == null)
                return;
            bool attachBehavior = (bool)newValue;
            if (attachBehavior)
            {
                entry.Behaviors.Add(new NumericValidationBehavior());
            }
            else
            {
                var toRemove = entry.Behaviors.FirstOrDefault(x => x is NumericValidationBehavior);
                if (toRemove!=null)
                {
                    entry.Behaviors.Remove(toRemove);
                }
            }
        }
        protected override void OnAttachedTo(Entry entry)
        {
            entry.TextChanged += Entry_TextChanged;
            base.OnAttachedTo(entry);
            // Perform setup

        }
        protected override void OnDetachingFrom(Entry entry)
        {
            entry.TextChanged -= Entry_TextChanged;
            base.OnDetachingFrom(entry);
            // Perform setup
        }
        private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            double result;
            bool isValid = double.TryParse(e.NewTextValue, out result);
            ((Entry)sender).TextColor = isValid ? Color.Default : Color.Red;
        }
    }
}
