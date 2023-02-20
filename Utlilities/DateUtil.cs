using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;
namespace ApiShopp.Utlilities
{
    public class DateUtil
    {
        public static DateTime? parserDate(string date, string format)
        {
            return !string.IsNullOrEmpty(date)
                ? DateTime.ParseExact(date, format, CultureInfo.InvariantCulture)
                : (DateTime?)null;
        }
    }
}
