using System;

namespace HackerRank
{
    public static partial class Solution
    {
        public static int queensAttack(int n, int k, int r_q, int c_q, int[][] obstacles)
        {
            var topLeft = c_q - Math.Min(n - r_q, c_q - 1);
            var top = n;
            var topRight = r_q + (n - Math.Max(r_q, c_q));
            var right = n;
            var buttomRight = c_q + Math.Min(r_q - 1, n - c_q);
            var buttom = 1;
            var buttomLeft = r_q - (Math.Min(r_q, c_q) - 1);
            var left = 1;

            foreach (var obstacle in obstacles)
            {
                if (obstacle[0] == r_q)
                {
                    if (obstacle[1] < c_q && obstacle[1] > left)
                        left = obstacle[1] + 1;
                    else if (obstacle[1] > c_q && obstacle[1] < right)
                        right = obstacle[1] - 1;
                }
                else if (obstacle[1] == c_q)
                {
                    if (obstacle[0] < r_q && obstacle[0] > buttom)
                        buttom = obstacle[0] + 1;
                    else if (obstacle[0] > r_q && obstacle[0] < top)
                        top = obstacle[0] - 1;
                }
                else if (obstacle[0] < r_q && obstacle[1] < c_q
                         && r_q - obstacle[0] == c_q - obstacle[1]
                         && buttomLeft < obstacle[0] + 1)
                {
                    buttomLeft = obstacle[0] + 1;
                }
                else if (obstacle[0] > r_q && obstacle[1] > c_q
                         && obstacle[0] - r_q == obstacle[1] - c_q
                         && topRight > obstacle[0] - 1)
                {
                    topRight = obstacle[0] - 1;
                }
                else if (obstacle[0] < r_q && obstacle[1] > c_q
                         && r_q - obstacle[0] == obstacle[1] - c_q
                         && buttomRight > obstacle[1] - 1)
                {
                    buttomRight = obstacle[1] - 1;
                }
                else if (obstacle[0] > r_q && obstacle[1] < c_q
                         && obstacle[0] - r_q == c_q - obstacle[1]
                         && topLeft < obstacle[1] + 1)
                {
                    topLeft = obstacle[1] + 1;
                }
            }

            return top - buttom
                   + right - left
                   + topRight - buttomLeft
                   + buttomRight - topLeft;
        }
    }
}
