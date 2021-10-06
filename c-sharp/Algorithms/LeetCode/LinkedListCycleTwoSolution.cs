using System.Collections.Generic;

namespace LeetCode
{
    namespace LinkedListCycleTwo
    {
        public class ListNode
        {
            public int val;
            public ListNode next;

            public ListNode(int x)
            {
                val = x;
                next = null;
            }
        }
    
        public class LinkedListCycleTwoSolution
        {
            public ListNode DetectCycle(ListNode head)
            {
                Dictionary<int, int> dict = new Dictionary<int, int>();
                ListNode current = head;
                int index = 0;
                while (current != null && dict.TryAdd(current.val, index))
                {
                    current = current.next;
                    index++;
                }

                return current;
            }
        }
    }

}