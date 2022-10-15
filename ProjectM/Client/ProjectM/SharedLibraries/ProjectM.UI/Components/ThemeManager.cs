using ProjectM.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ProjectM.UI
{
    public class ThemeManager
        : IThemeManager
    {
        public void UpdateTheme(AppTheme theme)
        {
            for (var i = 0; i < Application.Current.Resources.MergedDictionaries.Count; i++)
            {
                var dictionary = Application.Current.Resources.MergedDictionaries[i];
                if (string.IsNullOrEmpty(dictionary.Source?.OriginalString))
                {
                    continue;
                }
                if (dictionary.Source.OriginalString.StartsWith("/ProjectM.UI;component/Themes/"))
                {
                    Application.Current.Resources.MergedDictionaries.Remove(dictionary);
                    var resourceDictionary = new ResourceDictionary()
                    {
                        Source = new Uri($"/ProjectM.UI;component/Themes/{theme}.xaml", UriKind.RelativeOrAbsolute),
                    };
                    Application.Current.Resources.MergedDictionaries.Insert(i, resourceDictionary);
                    return;
                }
            }

        }

    }
}
