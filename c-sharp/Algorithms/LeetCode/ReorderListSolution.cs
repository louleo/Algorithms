using System.Collections.Generic;

namespace LeetCode
{
    public class ReorderListSolution
    {
        public void ReorderList(ListNode head)
        {
            List<ListNode> list = new List<ListNode>();
            ListNode current = head;
            while (current != null)
            {
                list.Add(current);
                current = current.next;
            }

            int leftP = 0;
            int rightP = list.Count - 1;
            bool leftParent = true;
            while (leftP < rightP)
            {
                if (leftParent)
                {
                    list[leftP].next = list[rightP];
                    leftParent = false;
                    leftP++;
                }
                else
                {
                    list[rightP].next = list[leftP];
                    leftParent = true;
                    rightP--;
                }
            }

            if (leftParent)
            {
                list[leftP].next = null;
            }
            else
            {
                list[rightP].next = null;
            }
        }


        public ListNode ReverseList(ListNode head)
        {
            ListNode current = head;
            ListNode preCurrent = null;
            while (current != null)
            {
                ListNode temp = current.next;
                current.next = preCurrent;
                preCurrent = current;
                current = temp;
            }

            return preCurrent;
        }
    }
}