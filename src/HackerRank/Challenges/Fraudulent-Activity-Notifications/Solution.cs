using System.Collections.Generic;

namespace HackerRank
{
    public static partial class Solution
    {
        /// <summary>
        /// Calculates the total number of times the client receives a notification over a period of n days
        /// </summary>
        /// <param name="expenditure">An array of integers representing daily expenditures</param>
        /// <param name="d">The lookback days for median spending</param>
        public static int activityNotifications(int[] expenditure, int d)
        {
            var ans = 0;
            var freq = new Dictionary<int, int>();

            for (var i = 0; i < expenditure.Length; i++)
            {
                if (i >= d)
                {
                    var m = d / 2;
                    var r = d % 2;

                    var m1 = FindMedian(freq, m + r);

                    var m2 = r == 1 
                        ? m1 
                        : FindMedian(freq, m + 1);

                    if (expenditure[i] >= m1 + m2)
                        ans++;

                    freq[expenditure[i - d]]--;
                }

                if (freq.ContainsKey(expenditure[i]))
                    freq[expenditure[i]]++;
                else
                    freq.Add(expenditure[i], 1);
            }

            return ans;
        }

        private static int FindMedian(IDictionary<int, int> freq, int index)
        {
            var sum = 0;
            var result = 0;

            while (result <= 200 && sum < index)
            {
                if (freq.TryGetValue(result++, out var f))
                    sum += f;
            }

            return result - 1;
        }
    }
}
