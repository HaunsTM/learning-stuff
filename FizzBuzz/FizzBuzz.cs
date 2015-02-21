using System;

namespace FizzBuzz
{
    internal class FizzBuzz
    {
        public void Start(int minRangeBound, int maxRangeBound, int fizzOutputInteger, int buzzOutputInteger)
        {
            var fizz = "Fizz";
            var buzz = "Buzz";

            Console.WriteLine(String.Format("Printing a numerical sequence from {0} to {1}", minRangeBound, maxRangeBound));
            Console.WriteLine(String.Format("If number is equally divisible by {0}, then the word \"{1}\" is output", fizzOutputInteger, fizz));
            Console.WriteLine(String.Format("If number is equally divisible by {0}, then the word \"{1}\" is output", buzzOutputInteger, buzz));

            for (var currentInteger = minRangeBound; currentInteger < maxRangeBound; currentInteger++)
            {
                Console.WriteLine("{0}\t{1}{2}", currentInteger, IsEquallyDivisible(currentInteger, fizzOutputInteger)? fizz:"",
                                                                             IsEquallyDivisible(currentInteger, buzzOutputInteger)? buzz:"");
            }
            
            Console.WriteLine("Done!");
        }

        private bool IsEquallyDivisible(int numerator, int denominator)
        {
            var isEquallyDivisible = numerator%denominator == 0;
            return isEquallyDivisible;
        }

    }
}
