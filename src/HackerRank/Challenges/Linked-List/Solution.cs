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
        /// <param name="head">A SinglyLinkedListNode pointer to the head of the list</param>
        public static void printLinkedList(SinglyLinkedListNode head)
        {
            var node = head;

            while (node != null)
            {
                Console.WriteLine(node.Data);
                node = node.Next;
            }
        }


        /// <summary>
        /// Returns a reference to the list head.
        /// https://www.hackerrank.com/challenges/insert-a-node-at-a-specific-position-in-a-linked-list/problem
        /// </summary>
        /// <param name="head">A SinglyLinkedListNode pointer to the head of the list</param>
        /// <param name="data">An integer value to insert as data in your new node</param>
        /// <param name="position">An integer position to insert the new node, zero based indexing</param>
        public static SinglyLinkedListNode insertNodeAtPosition(SinglyLinkedListNode head, int data, int position)
        {
            var node = head;

            for (var i = 0; i < position - 1; i++)
            {
                node = node.Next;
            }

            node.Next = new SinglyLinkedListNode(data)
            {
                Next = node.Next
            };

            return head;
        }


        /// <summary>
        /// Deletes the node at the given position and return the head node.
        /// https://www.hackerrank.com/challenges/delete-a-node-from-a-linked-list/problem
        /// </summary>
        /// <param name="head">A SinglyLinkedListNode pointer to the head of the list</param>
        /// <param name="position">The position of the node to delete</param>
        public static SinglyLinkedListNode deleteNode(SinglyLinkedListNode head, int position)
        {
            if (position == 0) { return head.Next; }

            head.Next = deleteNode(head.Next, position - 1);

            return head;
        }


        /// <summary>
        /// Print the elements of the linked list in the reverse order.
        /// https://www.hackerrank.com/challenges/print-the-elements-of-a-linked-list-in-reverse/problem
        /// </summary>
        /// <param name="head">A SinglyLinkedListNode pointer to the head of the list</param>
        public static void reversePrint(SinglyLinkedListNode head)
        {
            if (head.Next != null) { reversePrint(head.Next); }

            Console.WriteLine(head.Data);
        }


        /// <summary>
        /// Returns the head of the reversed linked list
        /// https://www.hackerrank.com/challenges/reverse-a-linked-list/problem
        /// </summary>
        /// <param name="head">A SinglyLinkedListNode pointer to the head of the list</param>
        public static SinglyLinkedListNode reverse(SinglyLinkedListNode head)
        {
            SinglyLinkedListNode prev = null;
            var current = head;
            SinglyLinkedListNode next = null;

            while (current != null)
            {
                next = current.Next;
                current.Next = prev;
                prev = current;
                current = next;
            }

            return prev;
        }
    }
}
