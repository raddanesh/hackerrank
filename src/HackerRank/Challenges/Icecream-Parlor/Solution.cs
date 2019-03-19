using System.Collections.Generic;

namespace HackerRank
{
    public static partial class Solution
    {
        public static int[] icecreamParlor(int m, int[] arr)
        {
            var priceFrequency = new Dictionary<int, int>();

            foreach (var p in arr)
            {
                if (priceFrequency.TryGetValue(p, out var _))
                    priceFrequency[p]++;
                else
                    priceFrequency.Add(p, 1);
            }

            for (var i = 0; i < arr.Length; i++)
            {
                var p1 = arr[i];
                var p2 = m - p1;
                if (p2 > 0 && priceFrequency.TryGetValue(p2, out var _))
                {
                    if (p1 == p2 && priceFrequency[p2] < 2) continue;

                    var j = -1;

                    for (var k = 0; k < arr.Length; k++)
                    {
                        if (k != i && arr[k] == p2)
                        {
                            j = k;
                            break;
                        }
                    }

                    if (j >= 0)
                    {
                        return j > i
                            ? new[] { i + 1, j + 1 }
                            : new[] { j + 1, i + 1 };
                    }
                }
            }

            return new[] { 0, 0 };
        }
    }
}
