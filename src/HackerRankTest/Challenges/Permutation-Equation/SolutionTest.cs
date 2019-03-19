using HackerRank;
using Xunit;

namespace HackerRankTest
{
    public partial class SolutionTest
    {
        [Theory]
        [InlineData(new[] { 2, 3, 1 },
            new[] { 2, 3, 1 })]
        [InlineData(new[] { 4, 3, 5, 1, 2 },
            new[] { 1, 3, 5, 4, 2 })]
        [InlineData(new[] { 2, 5, 11, 10, 1, 14, 7, 3, 16, 9, 8, 6, 18, 12, 15, 17, 13, 4 },
            new[] { 2, 5, 11, 13, 1, 14, 7, 3, 4, 18, 8, 6, 16, 12, 15, 10, 9, 17 })]
        public void PermutationEquationTest(int[] input, int[] expectedOutput )
        {
            // Act
            var actualOutput = Solution.permutationEquation(input);

            // Assert
            Assert.Equal(expectedOutput, actualOutput);
        }
    }
}
