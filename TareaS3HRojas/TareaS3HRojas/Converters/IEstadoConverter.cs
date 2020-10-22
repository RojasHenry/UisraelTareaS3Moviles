using System;
using System.Globalization;
using Xamarin.Forms;

namespace TareaS2HRojas.Converters
{
    public class IEstadoConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value.Equals("Aprobado"))
            {
                return Color.DarkGreen;
            }
            else
            {
                return Color.Red;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
