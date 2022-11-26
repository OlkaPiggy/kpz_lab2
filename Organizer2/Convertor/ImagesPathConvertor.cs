using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace Organizer2.Convertor
{
    public class ImagesPathConvertor : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var item = value.ToString();
            //var uri = new Uri(String.Format(@"../Images/{1}/{0}_icon.png", item, parameter), UriKind.Relative);
            var uri = new Uri(String.Format(@"../Images/{1}/{0}_icon.png", item,parameter), UriKind.Relative);

            return new BitmapImage(uri);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
