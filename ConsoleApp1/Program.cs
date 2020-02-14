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
                Console.WriteLine("Please, enter integers");
                return;
            }
            var res = Disc.Func(A);
            Console.WriteLine(res);
            Console.Read();
        }

        static int[] Input()
        {
            var input = Console.ReadLine().Split();
            int[] temp = new int[input.Length];
            for (int i = 0; i < input.Length; ++i)
                if (!int.TryParse(input[i], out temp[i]))
                {
                    return null;
                }
            return temp;
        }
    }        
}
