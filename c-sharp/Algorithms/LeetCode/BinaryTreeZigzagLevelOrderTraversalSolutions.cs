using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using LeetCode.CountGoodNodesInBinaryTree;

namespace LeetCode
{
    public class BinaryTreeZigzagLevelOrderTraversalSolutions
    {
        public IList<IList<int>> ZigzagLevelOrder(TreeNode root)
        {
            IList<IList<int>> result = new List<IList<int>>();
            if (root == null) return result;
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            bool order = true;
            while (queue.Count != 0)
            {
                int size = queue.Count;
                List<int> currentLevel = new List<int>();
                for (int i = 0; i < size; i++)
                {
                    TreeNode currentNode = queue.Dequeue();
                    if (order)
                    {
                        currentLevel.Add(currentNode.val);
                    }
                    else
                    {
                        currentLevel.Insert(0, currentNode.val);
                    }
                    if(currentNode.left != null) queue.Enqueue(currentNode.left);
                    if(currentNode.right != null) queue.Enqueue(currentNode.right);
                }
                result.Add(currentLevel);
                order = !order;
            }

            return result;
        }
    }
}