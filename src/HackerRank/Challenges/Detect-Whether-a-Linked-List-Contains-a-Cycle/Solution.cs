using HackerRank.Helpers;

namespace HackerRank
{
    public static partial class Solution
    {
        public static bool hasCycle(SinglyLinkedListNode head)
        {
            var fast = head;
            var slow = head;

            while (fast?.Next != null)
            {
                slow = slow.Next;
                fast = fast.Next.Next;

                if (slow == fast)
                    return true;
            }

            return false;
        }
    }
}
