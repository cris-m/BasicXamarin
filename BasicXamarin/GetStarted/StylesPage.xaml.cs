using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.StyleSheets;
using Xamarin.Forms.Xaml;

namespace BasicXamarin.GetStarted
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StylesPage : ContentPage
    {
        public StylesPage()
        {
            InitializeComponent();
            using (var reader = new StringReader("#MainLabel{ font-size: 30; font-style: italic; text-align: center; text-decoration:strikethrough;}"))
            {
                this.Resources.Add(StyleSheet.FromReader(reader));
            }
        }
    }
}