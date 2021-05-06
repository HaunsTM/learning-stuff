using System.Linq;

namespace Codility
{
    class _10_PrimeAndCompositeNumbers_CountFactors
    {   
        public int solution(int N)
        {
            var nbrOfFactors = 0;

            var integerThatIsAlwaysADivisor = 1;
            for (int i = integerThatIsAlwaysADivisor; i < N + 1; i++)
            {
                if ( N%i == 0) nbrOfFactors++;
            }

            return nbrOfFactors;
        }
    }
}
