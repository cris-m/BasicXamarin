using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace BasicXamarin.Droid.Extensions
{
    public static class ViewGroupExtensions
    {
        public static IEnumerable<T> GetChildrenOfType<T>(this ViewGroup viewGroup) where T : View
        {
            for (int i = 0; i < viewGroup.ChildCount; i++)
            {
                View child = viewGroup.GetChildAt(i);

                if (child is T expectedChild)
                    yield return expectedChild;

                if (child is ViewGroup childViewGroup)
                {
                    foreach (var expectedInnerChild in GetChildrenOfType<T>(childViewGroup))
                    {
                        yield return expectedInnerChild;
                    }
                }
            }
        }
    }
}