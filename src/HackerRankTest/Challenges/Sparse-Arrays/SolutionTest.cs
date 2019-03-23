using System.Collections.Generic;
using HackerRank;
using Xunit;

namespace HackerRankTest
{
    public partial class SolutionTest
    {
        [Theory]
        [MemberData(nameof(MatchingStringsData))]
        public void matchingStringsTest(string[] strings, string[] queries, int[] expectedOutput)
        {
            // Act
            var actualOutput = Solution.matchingStrings(strings, queries);

            // Assert
            Assert.Equal(expectedOutput, actualOutput);
        }

        public static IEnumerable<object[]> MatchingStringsData =>
            new List<object[]>
            {
                new object[] { 
                    new[] { "def", "de", "fgh" },
                    new[] { "de", "lmn", "fgh" },
                    new[] { 1, 0, 1 }
                },
                new object[] {
                    new[] {
                        "abcde",
                        "sdaklfj",
                        "asdjf",
                        "na",
                        "basdn",
                        "sdaklfj",
                        "asdjf",
                        "na",
                        "asdjf",
                        "na",
                        "basdn",
                        "sdaklfj",
                        "asdjf"
                    },
                    new[] {
                        "abcde",
                        "sdaklfj",
                        "asdjf",
                        "na",
                        "basdn"
                    },
                    new [] { 1, 3, 4, 3, 2 }
                }
            };
    }
}
