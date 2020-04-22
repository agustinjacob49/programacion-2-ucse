using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase4Logica
{
    public static class DateUtilsExtensions
    {
        public static decimal differenceInMinutes(this DateTime _firstDate, DateTime _secondDate)
        {
            return new decimal(System.Math.Abs((_firstDate - _secondDate).TotalSeconds) / 60);
        }

        public static DateTime toDateTime(this string _dateTimeInString)
        {
            try
            {
                DateTime parsedDate = DateTime.Parse(_dateTimeInString);
                return parsedDate;
            }catch(Exception e)
            {
               return DateTime.MinValue;
            }
           
        }

    }
}
