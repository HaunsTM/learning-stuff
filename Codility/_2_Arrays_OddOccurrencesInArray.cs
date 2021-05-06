using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Codility
{
    class _2_Arrays_OddOccurrencesInArray
    {   
        private class Ocurrence
        {
            public Ocurrence(int listElementValue, int nbrOfOcurrences)
            {
                ListElementValue = listElementValue;
                NbrOfOcurrences = nbrOfOcurrences;
            }
            public int ListElementValue { get; set; }
            public int NbrOfOcurrences { get; set; }
        }

        public int solution(int[] A)
        {
            int valueOfUnpairedElement = -1;

            var distinctA = A.Select( a => a ).Distinct().ToList();
            var occurencesList = distinctA.Select(dA => new Ocurrence( dA, A.Count(a => dA == a) )).ToList();

            var elementThatOccursOnlyOnce = occurencesList.First(a => a.NbrOfOcurrences == 1);
            valueOfUnpairedElement = elementThatOccursOnlyOnce.ListElementValue;

            return valueOfUnpairedElement;
        }
    }
}
