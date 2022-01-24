using System.Collections.Generic;

namespace LeetCode
{
    namespace CopyListWithRandomPointer
    {
        public class CopyListWithRandomPointerSolution
        {
            public Node CopyRandomList(Node head)
            {
                if (head == null) return null;
                
                Dictionary<Node, Node> map = new Dictionary<Node, Node>();
                Node current = head;
                while (current != null)
                {
                    map.Add(current, new Node(current.val));
                    current = current.next;
                }

                current = head;
                while (current != null)
                {
                    if (current.next != null)
                    {
                        map[current].next = map[current.next];
                    }

                    if (current.random != null)
                    {
                        map[current].random = map[current.random];
                    }

                    current = current.next;
                }

                return map[head];
            }
            public Node CopyRandomList2(Node head)
            {
                if (head is null)
                {
                    return null;
                }
                List<Node> nodeList = new List<Node>();
                List<Node> newNodeList = new List<Node>();
                Node current = head;
                while (current != null)
                {
                    nodeList.Add(current);
                    Node newCurrent = new Node(current.val);
                    if (newNodeList.Count >= 1)
                    {
                        newNodeList[^1].next = newCurrent;
                    }
                    newNodeList.Add(newCurrent);
                    current = current.next;
                }

                for (int i = 0; i < nodeList.Count; i++)
                {
                    if (nodeList[i].random != null)
                    {
                        int newNodeIndex = nodeList.IndexOf(nodeList[i].random);
                        if (newNodeIndex < newNodeList.Count)
                        {
                            newNodeList[i].random = newNodeList[newNodeIndex];
                        }
                    }
                }

                return newNodeList[0];
            }
        }
        public class Node {
            public int val;
            public Node next;
            public Node random;
    
            public Node(int _val) {
                val = _val;
                next = null;
                random = null;
            }
        }
    }

}