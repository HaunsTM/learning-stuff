using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Codility
{
    class _1_Iterations_BinaryGap
    {   
        public int solution(int N)
        {
            // binary representation of int
            int binaryBase = 2;
            string binaryRepresentationN = Convert.ToString(N, binaryBase);

            // ... Use named group in regular expression.
            Regex binaryGapRegex = new Regex(@"(?<=1)(?<binaryGap>0+)(?=1)");

            var allBinaryGapMatches = binaryGapRegex.Matches(binaryRepresentationN);

            if (allBinaryGapMatches.Count > 0)
            {
                var binaryGapLengthsList = new List<int>();
                foreach (Match match in allBinaryGapMatches)
                {
                    var currentBinaryGap = match.Groups["binaryGap"].Value;
                    var currentBinaryGapLength = currentBinaryGap.Length;

                    binaryGapLengthsList.Add(currentBinaryGapLength);
                }
                var maxBinaryGapLength = binaryGapLengthsList.Max();
                return maxBinaryGapLength;
            }

            return 0;
        }
    }
}
