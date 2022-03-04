using System.Collections.Generic;
using System.Security.Cryptography;

namespace LeetCode
{
    public class ReverseLinkedListTwoSolution
    {
        public ListNode ReverseBetween(ListNode head, int left, int right)
        {
            if (left == right)
            {
                return head;
            }
            
            IList<ListNode> list = new List<ListNode>();
            ListNode current = head;
            while (current != null)
            {
                list.Add(current);
                current = current.next;
            }

            left -= 1;
            right -= 1;


            while (left < right)
            {
                (list[left], list[right]) = (list[right], list[left]);
                left++;
                right--;
            }

            for (int i = 0; i < list.Count - 1; i++)
            {
                list[i].next = list[i + 1];
            }

            list[^1].next = null;
            
            return list[0];
        }
        
        
    }
}