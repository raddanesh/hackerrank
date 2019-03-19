namespace HackerRank
{
    public static partial class Solution
    {
        public static int[] permutationEquation(int[] p)
        {
            var answer = new int[p.Length];
            var pInversion = new int[p.Length];

            for (var i = 0; i < p.Length; i++)
                pInversion[p[i] - 1] = i + 1;

            for (var i = 0; i < pInversion.Length; i++)
                answer[i] = pInversion[pInversion[i] - 1];

            return answer;
        }
    }
}
