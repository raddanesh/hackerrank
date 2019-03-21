using HackerRank;
using Xunit;

namespace HackerRankTest
{
    public partial class SolutionTest
    {
        [Theory]
        [InlineData(new[] { 2, 3, 4, 2, 3, 6, 8, 4, 5 }, 5, 2)]
        [InlineData(new[] { 1, 2, 3, 4, 4 }, 4, 0)]
        [InlineData(new[] { 10, 20, 30, 40, 50 }, 3, 1)]
        public void activityNotificationsTest(int[] expenditure, int d, int expectedOutput)
        {
            // Act
            var actualOutput = Solution.activityNotifications(expenditure, d);

            // Assert
            Assert.Equal(expectedOutput, actualOutput);
        }
    }
}
