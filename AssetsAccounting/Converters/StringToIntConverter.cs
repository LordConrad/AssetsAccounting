using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace AssetsAccounting.Converters
{
    public class StringToIntConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value.ToString();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string val = value as string;
            int res;
            if (!int.TryParse(value as string, out res) && !string.IsNullOrEmpty(val))
            {
                string oldVal = val.Substring(0, val.Length - 1);
                int.TryParse(oldVal, out res);
            }
            return res;
        }
    }
}
