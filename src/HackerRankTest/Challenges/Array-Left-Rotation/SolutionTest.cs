using HackerRank;
using Xunit;

namespace HackerRankTest
{
    public partial class SolutionTest
    {
        [Theory]
        [InlineData(new[]{ 1, 2, 3, 4, 5 }, 5, 4, new[]{ 5, 1, 2, 3, 4 })]
        public void arrayLeftRotationTest(int[] a, int n, int d, int[] expectedOutput)
        {
            // Act
            var actualOutput = Solution.arrayLeftRotation(a, n, d);

            // Assert
            Assert.Equal(expectedOutput, actualOutput);
        }
    }
}
