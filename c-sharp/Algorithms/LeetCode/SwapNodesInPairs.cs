using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace LeetCode
{
    public class SwapNodesInPairs
    {
        public ListNode SwapPairs(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return head;
            }

            ListNode newHead = head.next;
            head.next = SwapPairs(newHead.next);
            newHead.next = head;
            return newHead;
        }
    }
}