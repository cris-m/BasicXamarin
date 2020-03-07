using Plugin.Multilingual;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Resources;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BasicXamarin.Localization.Helper
{
    [ContentProperty("Text")]
    class TranslateExtension : IMarkupExtension
    {
        const string ResourceId = "BasicXamarin.Localization.Resources.AppResources";
        static Lazy<ResourceManager> resourceMessage = new Lazy<ResourceManager>(() => new ResourceManager(ResourceId, typeof(TranslateExtension).GetTypeInfo().Assembly));
        public string Text { get; set; }
        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (Text == null)
                return string.Empty;
            var cultureInfo = CrossMultilingual.Current.CurrentCultureInfo;
            var translion = resourceMessage.Value.GetString(Text, cultureInfo);
            if(translion == null)
            {
#if DEBUG
                throw new ArgumentException(string.Format("Key '{0}' was not found in resource '{1}' for culture '{2}'.", Text, ResourceId, cultureInfo.Name), "Text");
#else
                translate = Text
#endif
            }
            return translion;
        }
    }
}
