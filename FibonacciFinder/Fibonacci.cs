using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciFinder
{
    public class Fibonacci
    {

        public static int GetValueForNumber(int n)
        {
            if (n == 0)
                return 0;
            else if (n == 1)
                return 1;
            else
                return (GetValueForNumber(n - 1) + GetValueForNumber(n - 2));
        }

        
    }
}
