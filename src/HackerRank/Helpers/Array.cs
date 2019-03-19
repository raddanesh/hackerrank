namespace HackerRank.Helpers
{
    public static class Array
    {
        public static int BinarySearch(int[] inputArray, int key, int min, int max)
        {
            while (min <= max)
            {
                var mid = (min + max) / 2;

                if (key == inputArray[mid])
                    return mid;

                if (key < inputArray[mid])
                    max = mid - 1;
                else
                    min = mid + 1;
            }
            return -1;
        }

        public static void QuickSort(int[] data, int l, int r)
        {
            var i = l == -1 ? 0 : l;
            var j = r == -1 ? data.Length : r;

            var x = data[(l + r) / 2];
            while (true)
            {
                while (data[i] < x)
                    i++;
                while (x < data[j])
                    j--;
                if (i <= j)
                {
                    Exchange(data, i, j);
                    i++;
                    j--;
                }
                if (i > j)
                    break;
            }
            if (l < j)
                QuickSort(data, l, j);
            if (i < r)
                QuickSort(data, i, r);
        }

        private static void Exchange(int[] data, int m, int n)
        {
            var temporary = data[m];

            data[m] = data[n];
            data[n] = temporary;
        }
    }
}
