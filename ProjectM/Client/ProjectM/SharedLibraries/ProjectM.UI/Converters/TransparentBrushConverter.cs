using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace ProjectM.UI.Converters
{
    public class TransparentBrushConverter
        : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var brush = (Brush)value;
            var opacity = double.Parse(parameter.ToString());

            brush = brush.CloneCurrentValue();
            brush.Opacity = opacity;

            return brush;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
