using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace BasicXamarin.Triggers
{
    public class NumericValidationTriggerAction : TriggerAction<Entry>
    {
        protected override void Invoke(Entry entry)
        {
            double result;
            bool isValid = double.TryParse(entry.Text, out result);
            entry.TextColor = isValid ? Color.Default : Color.Red;
        }
    }
}
