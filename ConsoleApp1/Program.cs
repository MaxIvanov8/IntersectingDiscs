using System;
using System.Linq;

namespace Interval
{
    internal class Program
    {
        private static void Main()
        {
            var input = Input();
            if (input == null)
            {
                return;
            }
            var res = Disc.Func(input);
            Console.WriteLine("Count of intersecting discs: " + res);
            Console.Read();
        }

        private static int[] Input()
        {
            Console.WriteLine("Input radius of every disc");
            var input = Console.ReadLine().Split();
            var temp = new int[input.Length];
            if (input.Where((t, i) => !int.TryParse(t, out temp[i])).Any())
            {
                Console.WriteLine("Please, enter integers");
                return null;
            }
            return temp;
        }
    }        
}
