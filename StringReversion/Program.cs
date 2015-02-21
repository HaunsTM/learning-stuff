using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringReversion
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Syftet med applikationen är att läsa in en sträng och därefter skriva ut den baklänges.");
            Console.Write("Ange strängen som ska skrivas ut baklänges: ");

            var stringToBeInverted = Console.ReadLine();
            var stringInverted = StringReverter.Revert(stringToBeInverted);

            Console.WriteLine(String.Format("Strängen baklänges: {0}", stringInverted));
            Console.ReadLine();
        }
    }
}
