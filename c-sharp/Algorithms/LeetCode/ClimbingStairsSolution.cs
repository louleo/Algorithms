using System.Collections.Generic;
using System.Security.Principal;

namespace LeetCode
{
    namespace ClimbingStair
    {
            public class ClimbingStairsSolution
    {
        private IList<TreeNode> _nodeList;
        private TreeNode _root;
        public ClimbingStairsSolution()
        {
            _nodeList = new List<TreeNode>();
            _root = new TreeNode();
            _nodeList.Add(_root);
        }
        
        public int ClimbStairs(int n)
        {
            /*
             * start from 1 and 2
             */
            if (n == 1) return 1;

            int nSteps = 1;
            int nStep1 = 0;
            int nStep2 = 0;
            
            for (int i = 1; i <= n; i++)
            {
                nStep2 = nStep1;
                nStep1 = nSteps;
                nSteps = nStep1 + nStep2;
            }

            return nSteps;
        }

        private int ClimbStairsDP(int n)
        {
            /*
             * start from 1 and 2
             * f(n) = f(n-1) + f(n-2)
             */
            if (n == 1) return 1;
            int[] dp = new int[n + 1];
            dp[1] = 1;
            dp[2] = 2;
            
            for (int i = 3; i < dp.Length; i++)
            {
                dp[i] = dp[i - 1] + dp[i - 2];
            }

            return dp[n];
        }

        private int ClimbStairsInternal(int n)
        {
            /*
             * f(n) = f(n-1) + f(n - 2)
             */
            if (n == 1)
            {
                return 1;
            }

            if (n == 2)
            {
                return 2;
            }

            if (n < 0)
            {
                return 0;
            }
            return ClimbStairsInternal(n - 1) + ClimbStairsInternal(n - 2);

        }

        private void ClimbStairsNode(int n, TreeNode parentNode)
        {
            if (n - 1 > 0)
            {
                parentNode.Left = new TreeNode(1, parentNode);
                _nodeList.Add(parentNode.Left);
                ClimbStairsNode(n-1, parentNode.Left);
            }else if (n - 1 == 0)
            {
                parentNode.Left = new TreeNode(1, parentNode);
                _nodeList.Add(parentNode.Left);
            }

            if (n - 2 > 0)
            {
                parentNode.Right = new TreeNode(2, parentNode);
                ClimbStairsNode(n - 2, parentNode.Right);
                _nodeList.Add(parentNode.Right);
            }else if (n - 2 == 0)
            {
                parentNode.Right = new TreeNode(2, parentNode);
                _nodeList.Add(parentNode.Right);
            }
        }
        
        
    }

    public class TreeNode
    {
        public int Value;
        public TreeNode Left = null;
        public TreeNode Right = null;
        public TreeNode Parent;

        public bool HasNoChild()
        {
            return Right is null && Left is null;
        }

        public TreeNode()
        {
            
        }

        public TreeNode(int value, TreeNode parent)
        {
            this.Value = value;
            this.Parent = parent;
        }
    }
    }

}

/*
 * 4
 * 1 -
 *   - 1
 *      - 1
 *          - 1
 *      - 2
 *   - 2
 *      - 1
 * 2 -
 *   - 1
 *     - 1
 *   - 2
*/