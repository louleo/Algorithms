using FluentAssertions;
using LeetCode;
using Xunit;

namespace LeetCodeTests
{
    public class AddTwoNumbersTests
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            ListNode l1 = ArrayToListNode(new int[] {2,4,3});
            ListNode l2 = ArrayToListNode(new int[] {5,6,4});
            AddTwoNumbersSolution solution = new AddTwoNumbersSolution();
            ListNode expectedResult = ArrayToListNode(new int[] {7, 0, 8});
            
            //Act
            ListNode result = solution.AddTwoNumbers(l1, l2);
            
            //Assert
            while (result != null && expectedResult !=null)
            {
                result.val.Should().Be(expectedResult.val);
                result = result.next;
                expectedResult = expectedResult.next;
            }

        }


        public ListNode ArrayToListNode(int[] arr)
        {
            ListNode ln = new ListNode();
            ListNode current = ln;
            if (arr.Length > 0)
            {
                ln.val = arr[0];
                int loopIndex = 1;
                while (loopIndex < arr.Length)
                {
                    current.next = new ListNode(arr[loopIndex]);
                    current = current.next;
                    loopIndex++;
                }
            }
            
            return ln;
        }
    }
}