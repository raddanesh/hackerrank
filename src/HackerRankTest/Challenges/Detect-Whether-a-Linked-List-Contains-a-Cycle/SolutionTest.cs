using System.Collections.Generic;
using HackerRank;
using HackerRank.Helpers;
using Xunit;

namespace HackerRankTest
{
    public partial class SolutionTest
    {
        [Theory]
        [InlineData(new[] { 1 }, false)]
        [InlineData(new[] { 1, 1 }, true)]
        [InlineData(new[] { 1, 2, 3, 4, 3 }, true)]
        [InlineData(new[] { 1, 2, 3, 4, 5, 1 }, true)]
        [InlineData(new[] { 1, 2, 3, 4, 5, 6 }, false)]
        public void hasCycleTest(int[] input, bool expectedOutput)
        {
            // Arrange
            var singlyLinkedListNode = CreateSinglyLinkedListNode(input);

            // Act
            var actualOutput = Solution.hasCycle(singlyLinkedListNode);

            // Assert
            Assert.Equal(expectedOutput, actualOutput);
        }

        private static SinglyLinkedListNode CreateSinglyLinkedListNode(int[] input)
        {
            SinglyLinkedListNode head = null;
            SinglyLinkedListNode tail = null;
            var dic = new Dictionary<int, SinglyLinkedListNode>();

            for (var i = 0; i < input.Length; i++)
            {
                if (!dic.TryGetValue(input[i], out var node))
                {
                    node = new SinglyLinkedListNode(input[i]);
                    dic.Add(input[i], node);
                }

                if (tail == null)
                    head = node;
                else
                    tail.Next = node;

                tail = node;
            }

            return head;
        }
    }
}
