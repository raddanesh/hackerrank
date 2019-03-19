namespace HackerRank
{
    public static partial class Solution
    {
        public static int[] arrayLeftRotation(int[] a, int n, int d)
        {
            var rotated = new int[n];

            for (var i = 0; i < n; i++)
            {
                rotated[(i + n - d) % n] = a[i];
            }

            return rotated;
        }
    }
}
