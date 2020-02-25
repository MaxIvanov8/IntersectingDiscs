using System;

namespace Intervals
{
    class Program
    {
        static void Main(string[] args)
        {
            var A = Input();
            if (A == null)
            {
                return;
            }
            var res = Disc.Func(A);
            Console.WriteLine("Count of intersecting discs: " + res);
            Console.Read();
        }

        static int[] Input()
        {
            Console.WriteLine("Input radius of every disc");
            var input = Console.ReadLine().Split();
            int[] temp = new int[input.Length];
            for (int i = 0; i < input.Length; ++i)
                if (!int.TryParse(input[i], out temp[i]))
                {
                    Console.WriteLine("Please, enter integers");
                    return null;
                }
            return temp;
        }
    }        
}
