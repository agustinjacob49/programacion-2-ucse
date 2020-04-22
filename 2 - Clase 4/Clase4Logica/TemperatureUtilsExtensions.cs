using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Clase4Logica
{
    public static class TemperatureUtilsExtensions
    {
        public static decimal toCelsius(this decimal _temp)
        {
            return _temp / new decimal(2.12);
        }

        public static decimal toFarenheit(this decimal _temp)
        {
            return _temp * new decimal(2.12);
        }

    }
}
