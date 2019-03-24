using System;
using HackerRank.Helpers;

namespace HackerRank
{
    public static partial class Solution
    {
        /// <summary>
        /// Prints the integer data for each element of the linked list to stdout/console
        /// https://www.hackerrank.com/challenges/print-the-elements-of-a-linked-list/problem
        /// </summary>
        /// <param name="head">The head of the linked list</param>
        public static void printLinkedList(SinglyLinkedListNode head)
        {
            var node = head;
            while (node != null)
            {
                Console.WriteLine(node.Data);
                node = node.Next;
            }
        }
    }
}
