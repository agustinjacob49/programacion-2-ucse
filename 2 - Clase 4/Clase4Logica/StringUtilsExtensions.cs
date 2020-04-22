using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Clase4Logica
{
    public static class StringUtilsExtensions
    {
        public static int countWords(this string _string)
        {
            return _string.Split().Length;
        }

        public static int countWords(this string _string, char separator)
        {
            return _string.Split(separator).Length;
        }

        public static string reverseString(this string _string)
        {
            char[] arrayToReverse = _string.ToCharArray();
            Array.Reverse(arrayToReverse);
            return new string(arrayToReverse);
        }

        public static string concatStringValues(this List<string> _list, char _separator)
        {
            string newBigString = "";
            _list.ForEach(i => newBigString += i + _separator);
            return newBigString;
        }

        public static bool isEmail(this string _string)
        {
            return Regex.IsMatch(_string, "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*");
        }

    }
}
