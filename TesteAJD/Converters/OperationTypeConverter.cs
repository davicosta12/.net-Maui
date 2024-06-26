using System.Globalization;

namespace TesteAJD.Converters
{
    public class OperationTypeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is string operationType)
            {
                return operationType == "D" ? "Devolução" : "Troca";
            }
            return "Troca";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
