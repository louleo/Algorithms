namespace LeetCode
{
    public class AddTwoNumbersSolution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            return Solution1(l1, l2);
        }


        public ListNode Solution1(ListNode l1, ListNode l2)
        {
            if (l1 is null)
            {
                return l2;
            }else if (l2 is null)
            {
                return l1;
            }
            int addOne = 0;
            ListNode result = new ListNode(l1.val+l2.val);
            if (result.val >= 10)
            {
                result.val -= 10;
                addOne += 1;
            }

            l1 = l1.next;
            l2 = l2.next;

            ListNode current = result;
            while (l1 != null && l2 != null)
            {
                current.next = new ListNode(addOne + l1.val + l2.val);
                addOne = 0;
                current = current.next;
                if (current.val >= 10)
                {
                    current.val -= 10;
                    addOne = 1;
                }

                l1 = l1.next;
                l2 = l2.next;
            }

            while (l1 != null)
            {
                current.next = new ListNode(addOne + l1.val);
                addOne = 0;
                current = current.next;
                if (current.val >= 10)
                {
                    current.val -= 10;
                    addOne = 1;
                }

                l1 = l1.next;
            }
            
            while (l2 != null)
            {
                current.next = new ListNode(addOne + l2.val);
                addOne = 0;
                current = current.next;
                if (current.val >= 10)
                {
                    current.val -= 10;
                    addOne = 1;
                }

                l2 = l2.next;
            }

            if (addOne == 1)
            {
                current.next = new ListNode(addOne);
            }

            return result;
        }
        
        
    }

    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}