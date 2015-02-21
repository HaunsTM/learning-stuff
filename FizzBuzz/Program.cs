using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            var fizzBuzzer = new FizzBuzz();
            var minRangeBound = 1;
            var maxRangeBound = 100;
            var fizzOutputInteger = 3;
            var buzzOutputInteger = 5;
            fizzBuzzer.Start(minRangeBound, maxRangeBound, fizzOutputInteger, buzzOutputInteger);
            Console.ReadLine();
        }
    }
}
