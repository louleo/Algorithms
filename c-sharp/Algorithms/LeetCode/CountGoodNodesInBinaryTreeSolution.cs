using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace LeetCode
{
    namespace CountGoodNodesInBinaryTree
    {
        public class CountGoodNodesInBinaryTreeSolution
        {
            private int goodNodesNum = 0;
            
            public int GoodNodes(TreeNode root)
            {
                GoodNodesDFS(root, root.val);
                return goodNodesNum;
            }
            private void GoodNodesDFS(TreeNode node, int currentMax)
            {
                if (node is null) return;
                
                if (node.val >= currentMax)
                {
                    currentMax = node.val;
                    goodNodesNum++;
                }

                GoodNodesDFS(node.left, currentMax);
                GoodNodesDFS(node.right, currentMax);
            }
        }

        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;

            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.right = right;
                this.left = left;
            }
        }
    }

}