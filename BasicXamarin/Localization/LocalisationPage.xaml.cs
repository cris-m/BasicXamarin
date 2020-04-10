using BasicXamarin.Localization.Model;
using BasicXamarin.Localization.Resources;
using Plugin.Multilingual;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BasicXamarin.Localization
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LocalisationPage : ContentPage
    {
        public ObservableCollection<Language> Languages { get; }
        public LocalisationPage()
        {
            InitializeComponent();
            Languages = new ObservableCollection<Language>()
            {
                new Language { DisplayName =  "中文 - Chinese (simplified)", ShortName = "zh-Hans" },
                //new Language { DisplayName =  "Chinese(Traditional)", ShortName = "zh-Hant" },
                new Language { DisplayName =  "English", ShortName = "en" },
                new Language { DisplayName =  "Français - French", ShortName = "fr" },
                new Language { DisplayName =  "Deutsche - German", ShortName = "de" },
                new Language { DisplayName =  "日本語 - Japanese", ShortName = "ja" },
                new Language { DisplayName =  "한국어 - Korean", ShortName = "ko" },
                new Language { DisplayName =  "Română - Romanian", ShortName = "ro" },
                new Language { DisplayName =  "Русский - Russian", ShortName = "ru" },
                new Language { DisplayName =  "عربى - Arabic", ShortName = "ar" }
            };
            BindingContext = this;
            PickerLanguages.Title = CrossMultilingual.Current.DeviceCultureInfo.DisplayName;
            PickerLanguages.SelectedIndexChanged += PickerLanguages_SelectedIndexChanged;
        }

        private void PickerLanguages_SelectedIndexChanged(object sender, EventArgs e)
        {
            var language = Languages[PickerLanguages.SelectedIndex];
            try
            {
                var culture = new CultureInfo(language.ShortName);
                AppResources.Culture = culture;
                CrossMultilingual.Current.CurrentCultureInfo = culture;
                PickerLanguages.Title = culture.DisplayName;


            }
            catch (Exception) { }
            LabelTranslate.Text = AppResources.HelloWorld;
            Username.Placeholder = AppResources.UserName;
        }
    }
}