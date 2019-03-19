using System;

namespace HackerRank.Helpers
{
    public class SinglyLinkedListNode<T> 
    {
        public T Data { get; set; }
        public SinglyLinkedListNode<T> Next { get; set; }

        public SinglyLinkedListNode(T data)
        {
            Data = data;
        }
    }

    public class SinglyLinkedListNode : IEquatable<SinglyLinkedListNode>
    {
        public int Data { get; set; }
        public SinglyLinkedListNode Next { get; set; }

        public SinglyLinkedListNode(int data)
        {
            Data = data;
        }

        public bool Equals(SinglyLinkedListNode other)
        {
            return Data == other?.Data;
        }
    }
}
