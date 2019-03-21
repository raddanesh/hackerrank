namespace HackerRank
{
    public static partial class Solution
    {
        /// <summary>
        /// Calculates the number of inversions that must be swapped to sort the dataset.
        /// https://www.hackerrank.com/challenges/ctci-merge-sort/problem
        /// </summary>
        /// <param name="arr">an array of integers to sort</param>
        public static long countInversions(int[] arr)
        {
            return MergeSortWithSwapCount(arr, 0, arr.Length - 1);
        }

        private static long MergeSortWithSwapCount(int[] arr, int left, int right)
        {
            if (right <= left)
            {
                return 0;
            }

            var mid = (right + left) / 2;

            var invCount = MergeSortWithSwapCount(arr, left, mid);
            invCount += MergeSortWithSwapCount(arr, mid + 1, right);

            invCount += MergeWithSwapCount(arr, left, mid + 1, right);

            return invCount;
        }

        private static long MergeWithSwapCount(int[] arr, int left, int mid, int right)
        {
            var temp = new int[right - left + 1];

            long invCount = 0;

            var i = left;
            var j = mid;
            var k = 0;

            while (i <= mid - 1 && j <= right)
            {
                if (arr[i] <= arr[j])
                {
                    temp[k++] = arr[i++];
                }
                else
                {
                    temp[k++] = arr[j++];

                    invCount = invCount + (mid - i);
                }
            }

            while (i <= mid - 1)
                temp[k++] = arr[i++];

            while (j <= right)
                temp[k++] = arr[j++];

            for (i = left; i <= right; i++)
                arr[i] = temp[i - left];

            return invCount;
        }
    }
}
