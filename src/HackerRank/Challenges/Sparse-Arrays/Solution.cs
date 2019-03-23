using System.Collections.Generic;

namespace HackerRank
{
    public static partial class Solution
    {
        /// <summary>
        /// Return an array of integers representing the frequency of occurrence of each query string in strings.
        /// https://www.hackerrank.com/challenges/sparse-arrays/problem
        /// </summary>
        /// <param name="strings">An array of strings to search</param>
        /// <param name="queries">An array of query strings</param>
        public static int[] matchingStrings(string[] strings, string[] queries)
        {
            var dic = new Dictionary<string, int>();
            var ans = new int[queries.Length];

            foreach (var s in strings)
            {
                if (dic.ContainsKey(s))
                    dic[s]++;
                else
                    dic[s] = 1;
            }

            for (var i = 0; i < queries.Length; i++)
            {
                if (!dic.TryGetValue(queries[i], out ans[i]))
                    ans[i] = 0;
            }

            return ans;
        }
    }
}
