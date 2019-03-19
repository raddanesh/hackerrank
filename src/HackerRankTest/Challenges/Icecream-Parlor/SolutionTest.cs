using HackerRank;
using Xunit;

namespace HackerRankTest
{
    public partial class SolutionTest
    {
        [Theory]
        [InlineData(4, new[] { 1, 4, 5, 3, 2 }, new[] { 1, 4 })]
        [InlineData(4, new[] { 2, 2, 4, 3 }, new[] { 1, 2 })]
        public void icecreamParlorTest(int m, int[] input, int[] expectedOutput)
        {
            // Act
            var actualOutput = Solution.icecreamParlor(m, input);

            // Assert
            Assert.Equal(expectedOutput, actualOutput);
        }
    }
}
