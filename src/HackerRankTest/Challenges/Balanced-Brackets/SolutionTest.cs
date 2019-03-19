using HackerRank;
using Xunit;

namespace HackerRankTest
{
    public partial class SolutionTest
    {
        [Theory]
        [InlineData("{(([])[])[]}", "YES")]
        [InlineData("{(([])[])[]]}", "NO")]
        [InlineData("{(([])[])[]}[]", "YES")]
        [InlineData("{{([])}}", "YES")]
        [InlineData("{{)[](}}", "NO")]
        public void isBalancedTest(string input, string expectedOutput)
        {
            // Act
            var actualOutput = Solution.isBalanced(input);

            // Assert
            Assert.Equal(expectedOutput, actualOutput);
        }
    }
}
