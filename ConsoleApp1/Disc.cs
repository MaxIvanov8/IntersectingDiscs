using System.Linq;

namespace Intervals
{
    class Disc
    {
        private long _left { get; set; }
        private long _right { get; set; }

        public static int Func(int[] A)
        {
            var discs = new Disc[A.Length];
            for (int i = 0; i < A.Length; i++)
                discs[i] = new Disc()
                {
                    _left = i - A[i],
                    _right = i + A[i]
                };
            discs = discs.OrderBy(i => i._left).ToArray();
            int sum = 0;
            for (int i = 0; i < discs.Length; i++)
            {
                var right = discs[i]._right;
                for (int j = i + 1; j < discs.Length && discs[j]._left <= right; j++)
                    sum++;
            }
            return sum;
        }
    }
}
