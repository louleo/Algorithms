using System.Collections.Generic;

namespace LeetCode
{
    public class MergeKSortedListsSolution
    {
        public ListNode MergeKLists(ListNode[] lists)
        {            
            Queue<ListNode> queue = new Queue<ListNode>();
            
            foreach (var node in lists)
            {
                if (node != null)
                {
                    queue.Enqueue(node);
                }
            }
            
            if (queue.Count == 0)
            {
                return null;
            }
            
            ListNode ans = new ListNode();
            int currentLength = queue.Count;

            ListNode ansPrev = ans;
            ListNode result = ans;
            while (queue.Count > 0)
            {
                ListNode smallest = queue.Dequeue();
                for (int i = 1; i < currentLength; i++)
                {
                    var currentNode = queue.Dequeue();
                    if (currentNode.val < smallest.val)
                    {
                        queue.Enqueue(smallest);
                        smallest = currentNode;
                    }
                    else
                    {
                        queue.Enqueue(currentNode);
                    }
                }

                ans.val = smallest.val;
                ans.next = new ListNode();
                ansPrev = ans;
                ans = ans.next;
                smallest = smallest.next;
                if (smallest != null)
                {
                    queue.Enqueue(smallest);
                }

                currentLength = queue.Count;
            }

            ansPrev.next = null;
            return result;
        }
    }
}