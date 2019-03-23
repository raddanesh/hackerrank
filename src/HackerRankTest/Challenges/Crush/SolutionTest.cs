using System.Collections.Generic;
using HackerRank;
using Xunit;

namespace HackerRankTest
{
    public partial class SolutionTest
    {
        [Theory]
        [MemberData(nameof(ArrayManipulationData))]
        public void arrayManipulationTest(int n, int[][] queries, long expectedOutput)
        {
            // Act
            var actualOutput = Solution.arrayManipulation(n, queries);

            // Assert
            Assert.Equal(expectedOutput, actualOutput);
        }

        public static IEnumerable<object[]> ArrayManipulationData =>
            new List<object[]>
            {
                new object[] { 10,
                    new[] {
                        new[] { 1, 5, 3 },
                        new[] { 4, 8, 7 },
                        new[] { 6, 9, 1 }
                    }, 10},
                new object[] { 5,
                    new[] {
                        new[] { 1, 2, 100 },
                        new[] { 2, 5, 100 },
                        new[] { 3, 4, 100 }
                    }, 200},
            };
    }
}
