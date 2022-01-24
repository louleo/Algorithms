using LeetCode.CopyListWithRandomPointer;
using Xunit;

namespace LeetCodeTests
{
    public class CopyListWithRandomPointerTests
    {
        [Fact]
        public void TestCase1()
        {
            var head = new Node(7);
            var node2 = new Node(13);
            var node3 = new Node(11);
            var node4 = new Node(10);
            var node5 = new Node(1);
            head.next = node2;
            node2.next = node3;
            node3.next = node4;
            node4.next = node5;
            node2.random = head;
            node3.random = node5;
            node3.random = node3;
            node5.random = head;

            var sol = new CopyListWithRandomPointerSolution();
            sol.CopyRandomList(head);
        }
    }
}