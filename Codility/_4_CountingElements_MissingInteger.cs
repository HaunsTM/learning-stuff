using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Codility
{
    class _4_CountingElements_MissingInteger
    {
        private bool currentValueExistsInArray(int candidate, int[] sortedArrayWithoutMultiples)
        {
            var exists = sortedArrayWithoutMultiples.Any(x => x == candidate);

            return exists;
        }

        public int solution(int[] A)
        {
            var sortedArray = (int[])A.Clone();
            Array.Sort(sortedArray);
            var sortedArrayWithoutMultiples = sortedArray.Distinct().ToArray();

            var minA = sortedArrayWithoutMultiples.Min();
            var maxA = sortedArrayWithoutMultiples.Max();

            if (maxA < 1) return 1; // returns smallest positive integer (greater than 0)

            // do we have a homolog?
            for (int i = minA; i < maxA; i++)
            {
                var valueDoesNotExist = !currentValueExistsInArray(i, sortedArrayWithoutMultiples);

                if (valueDoesNotExist) return i;
            }

            // if we en up here we have a consecutive data serie, return maxA + 1
            var smallestPositiveIntegerGreaterThanMaxA = maxA + 1;
            return smallestPositiveIntegerGreaterThanMaxA;
        }
    }
}
