using System.Globalization;

namespace OilGasExtraction
{
    public class Converter : IValueConverter
    {
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
           if (value is double)
            {
                double val = double.Parse(value.ToString()) / 1000;

                return " " + val.ToString() + "K";
            }
            return null;
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
