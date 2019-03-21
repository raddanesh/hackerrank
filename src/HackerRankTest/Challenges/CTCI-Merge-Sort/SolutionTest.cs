using HackerRank;
using Xunit;

namespace HackerRankTest
{
    public partial class SolutionTest
    {
        [Theory]
        [InlineData(new[] { 1, 1, 1, 2, 2 }, 0)]
        [InlineData(new[] { 2, 1, 3, 1, 2 }, 4)]
        [InlineData(new[] { 1, 3, 5, 7 }, 0)]
        [InlineData(new[] { 3, 2, 1 }, 3)]
        public void countInversionsTest(int[] arr, long expectedOutput)
        {
            // Act
            var actualOutput = Solution.countInversions(arr);

            // Assert
            Assert.Equal(expectedOutput, actualOutput);
        }
    }
}
