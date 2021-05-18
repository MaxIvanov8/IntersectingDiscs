using System.Linq;

namespace Interval
{
    internal class Disc
    {
        private long _left;
        private long _right;

        public static int Func(int[] array)
        {

            var discs = new Disc[array.Length];
            for (var i = 0; i < array.Length; i++)
                discs[i] = new Disc()
                {
                    _left = i - array[i],
                    _right = i + array[i]
                };
            discs = discs.OrderBy(i => i._left).ToArray();
            var sum = 0;
            for (var i = 0; i < discs.Length; i++)
            {
                var right = discs[i]._right;
                for (var j = i + 1; j < discs.Length && discs[j]._left <= right; j++)
                    sum++;
            }
            return sum;
        }
    }
}
