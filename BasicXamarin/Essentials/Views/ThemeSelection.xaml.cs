using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using BasicXamarin.Essentials.Service;
using System.Collections;
using BasicXamarin.Essentials.Theme;

namespace BasicXamarin.Essentials.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ThemeSelection : ContentPage, IModalPage
    {
        public ThemeSelection()
        {
            InitializeComponent();
        }

        public async Task Dismiss()
        {
            await Navigation.PopModalAsync();
        }

        private void EnumPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            Picker picker = sender as Picker;
            Themes theme = (Themes)picker.SelectedIndex;

            ICollection<ResourceDictionary> mergedDictionaries = Application.Current.Resources.MergedDictionaries;
            if (mergedDictionaries != null)
            {
                mergedDictionaries.Clear();
                switch (theme)
                {
                    case Themes.Dark:
                        mergedDictionaries.Add(new DarkTheme());
                        break;
                    case Themes.Light:
                    default:
                        mergedDictionaries.Add(new LightTheme());
                        break;
                }
                statusLabel.Text = $"{theme.ToString()} theme loaded. Close this page.";
            }
        }
    }
}