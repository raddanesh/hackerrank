namespace HackerRank
{
    public static partial class Solution
    {
        /// <summary>
        /// Return an integer, the maximum value in the resulting array.
        /// https://www.hackerrank.com/challenges/crush/problem
        /// </summary>
        /// <param name="n">The number of elements in your array</param>
        /// <param name="queries">A two dimensional array of queries where each queries[i] contains three integers, a, b, and k.</param>
        public static long arrayManipulation(int n, int[][] queries)
        {
            var arr = new long[n];
            long ans = 0;
            long tmp = 0;

            foreach (var q in queries)
            {
                arr[q[0] - 1] += q[2];
                if (q[1] < n)
                    arr[q[1]] -= q[2];
            }

            for (var i = 0; i < n; i++)
            {
                tmp += arr[i];
                if (tmp > ans)
                    ans = tmp;
            }

            return ans;
        }
    }
}
