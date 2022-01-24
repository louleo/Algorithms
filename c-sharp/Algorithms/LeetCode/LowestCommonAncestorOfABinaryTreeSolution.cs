using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Runtime;

namespace LeetCode
{
    namespace LowestCommonAncestorOfABinaryTree
    {
        public class LowestCommonAncestorOfABinaryTreeSolution
        {
            private TreeNode ans;

            public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
            {
                TreeNode lca = root;
                TreeNode current = lca;
                while (current != null)
                {
                    if (current.left != null)
                    {
                        var leftP = DFS(current.left, p);
                        var leftQ = DFS(current.right, q);
                        if (leftP && leftQ)
                        {
                            lca = current.left;
                            current = lca;
                            continue;
                        }
                    }

                    if (current.right != null)
                    {
                        var rightP = DFS(current.right, p);
                        var rightQ = DFS(current.right, q);
                        if (rightP && rightQ)
                        {
                            lca = current.right;
                            current = lca;
                            continue;
                        }
                    }

                    break;
                }

                return lca;
            }

            private bool DFS(TreeNode node, TreeNode p)
            {
                if (node != null)
                {
                    if (node == p)
                    {
                        return true;
                    }
                    else
                    {
                        var left = DFS(node.left, p);
                        var right = DFS(node.right, p);
                        return left || right;
                    }
                }

                return false;
            }

            private bool NewDfs(TreeNode node, TreeNode p, TreeNode q)
            {
                if (node == null)
                {
                    return false;
                }

                var leftSon = NewDfs(node.left, p, q);
                var rightSon = NewDfs(node.right, p, q);

                if ((leftSon && rightSon) || (node.val == p.val && (leftSon || rightSon)) || (node.val == q.val && (leftSon || rightSon)))
                {
                    this.ans = node;
                }

                return leftSon || rightSon || (node.val == p.val || node.val == q.val);
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