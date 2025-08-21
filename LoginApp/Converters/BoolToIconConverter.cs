using LoginApp.Models;
using System.Globalization;

namespace LoginApp.Converters
{
	internal class BoolToIconConverter : IValueConverter
	{

        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
		{
			string icon = Icons.ClosedEyeIcon;
            if (value != null)
				icon =  (bool)value ? Icons.ClosedEyeIcon : Icons.OpenEyeIcon;
			return icon;
		}

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
