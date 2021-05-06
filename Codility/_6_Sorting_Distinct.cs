using System.Linq;

namespace Codility
{
    class _6_Sorting_Distinct
    {   
        public int solution(int[] A)
        {
            var nbrDistinctValuesInA = A.Distinct().Count();

            return nbrDistinctValuesInA;
        }
    }
}
