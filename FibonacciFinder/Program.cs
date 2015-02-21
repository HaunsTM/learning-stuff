using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciFinder
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Syftet med applikationen är att räkna ut ett tal i Fibonacci-serien med rekursion.");
            Console.Write("Ange vilket tal i serien som ska beräknas: ");

            var numberInSequence = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(String.Format("Tal #{0} i Fibonacci-serien har värdet {1}.", numberInSequence, Fibonacci.GetValueForNumber( numberInSequence)));            
            Console.ReadLine();
        }
    }
}
