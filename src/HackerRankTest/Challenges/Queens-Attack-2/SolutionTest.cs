using System.Collections.Generic;
using HackerRank;
using Xunit;

namespace HackerRankTest
{
    public partial class SolutionTest
    {
        [Theory]
        [MemberData(nameof(QueensAttackData))]
        public void queensAttackTest(int n, int k, int r_q, int c_q, int[][] obstacles, int expectedOutput)
        {
            // Act
            var actualOutput = Solution.queensAttack(n, k, r_q, c_q, obstacles);

            // Assert
            Assert.Equal(expectedOutput, actualOutput);
        }

        public static IEnumerable<object[]> QueensAttackData =>
            new List<object[]>
            {
                new object[] { 88587, 9, 20001, 20003,
                    new[] {
                        new[] { 20001, 20002 },
                        new[] { 20001, 20004 },
                        new[] { 20000, 20003 },
                        new[] { 20002, 20003 },
                        new[] { 20000, 20004 },
                        new[] { 20000, 20002 },
                        new[] { 20002, 20004 },
                        new[] { 20002, 20002 },
                        new[] { 564, 323 }
                    }, 0 },
                new object[] { 5, 3, 4, 3,
                    new[]
                    {
                        new[] { 5, 5 },
                        new[] { 4, 2 },
                        new[] { 2, 3 }
                    }, 10 },
                new object[] { 1, 0, 1, 1, new int[0][], 0 },
                new object[] { 4, 0, 4, 4, new int[0][], 9 }
            };
    }
}
