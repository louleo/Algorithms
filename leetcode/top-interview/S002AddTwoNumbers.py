# Definition for singly-linked list.
from typing import List
from helpers import compareList


class ListNode:
     def __init__(self, val=0, next=None):
         self.val = val
         self.next = next


class Solution:

    def addTwoNumbers(self, l1: ListNode, l2: ListNode) -> ListNode:
        self.addTwoNumbers1(l1,l2)


    def addTwoNumbers1(self, l1: ListNode, l2: ListNode) -> ListNode:
        newNode = l1
        currentNode = newNode
        up = 0
        while l1 is not None and l2 is not None:
            value = l1.val + l2.val + up
            if value >= 10:
                up = 1
                value -= 10
            else:
                up = 0
            l1.val = value
            currentNode = l1
            l1 = l1.next
            l2 = l2.next

        while l2 is not None and l1 is None:
            value = l2.val + up
            if value >= 10:
                up = 1
                value -= 10
            else:
                up = 0
            l2.val = value
            currentNode.next = l2
            currentNode = currentNode.next
            l2 = l2.next


        while l1 is not None and l2 is None:
            value = l1.val + up
            if value >= 10:
                up = 1
                value -= 10
            else:
                up = 0
            l1.val = value
            currentNode.next = l1
            currentNode = currentNode.next
            l1 = l1.next

        if up == 1:
            currentNode.next = ListNode(1)

        return newNode

    def addTwoNumbers2S(self, l1: ListNode, l2: ListNode) -> ListNode:
        result = ListNode(0)
        result_tail = result
        carry = 0

        while l1 or l2 or carry:
            val1 = (l1.val if l1 else 0)
            val2 = (l2.val if l2 else 0)
            carry, out = divmod(val1 + val2 + carry, 10)

            result_tail.next = ListNode(out)
            result_tail = result_tail.next

            l1 = (l1.next if l1 else None)
            l2 = (l2.next if l2 else None)

        return result.next



def formatToListNode(list: List[int]) -> ListNode:
    node = ListNode(list[0])
    currentNode = node
    for i in range(1, len(list)):
        currentNode.next = ListNode(list[i])
        currentNode = currentNode.next
    return node

def formatToList(node: ListNode) -> List[int]:
    list = []
    while(node is not None):
        list.append(node.val)
        node = node.next
    return list


def runTests():
    solution = Solution()

    input1_l1 = [2,4,3]
    input1_l2 = [5,6,4]
    output1 = [7,0,8]
    assertOutput1 = formatToList(solution.addTwoNumbers(formatToListNode(input1_l1), formatToListNode(input1_l2)))
    print(compareList(output1, assertOutput1))

    input1_l1 = [0]
    input1_l2 = [0]
    output1 = [0]
    assertOutput1 = formatToList(solution.addTwoNumbers(formatToListNode(input1_l1), formatToListNode(input1_l2)))
    print(compareList(output1, assertOutput1))


    input1_l1 = [9,9,9,9,9,9,9]
    input1_l2 = [9,9,9,9]
    output1 = [8,9,9,9,0,0,0,1]
    assertOutput1 = formatToList(solution.addTwoNumbers(formatToListNode(input1_l1), formatToListNode(input1_l2)))
    print(compareList(output1, assertOutput1))

