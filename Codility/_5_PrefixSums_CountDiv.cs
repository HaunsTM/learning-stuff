using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Codility
{
    class _5_PrefixSums_CountDiv
    {   
        public int solution(int A, int B, int K)
        {
            var nbrDivisibleIntegers = 0;

            for (int i = A; i < B; i++)
            {
                if (i % K == 0)
                {
                    nbrDivisibleIntegers++;
                }
            }

            return nbrDivisibleIntegers;
        }
    }
}
