using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase4Logica
{
    public static class ListUtilsExtensions
    {
        public static decimal averageValue(this List<int> _list)
        {
            int sum = 0;
            _list.ForEach(i => sum += i);
            return new decimal(sum / _list.Count);
        }

        public static decimal pairsValuesMultiplyNonPairs(this List<int> _list)
        {
            int pairs = 0;
            int nonPairs = 0;
            _list.ForEach(i => {
                if(i % 2 == 0) {
                    pairs += i;
                }
                else
                {
                    nonPairs -= i;
                }
            });
            return new decimal(pairs * nonPairs);
        }

    }
}
