using System.ComponentModel;
using LeetCode.LowestCommonAncestorOfABinaryTree;

namespace LeetCode
{
    public class ValidateBinarySearchTreeSolution
    {
        public bool IsValidBST(TreeNode root)
        {
            if (root == null) return false;
            bool isLeftValidBST = true;
            bool isRightValidBST = true;
            if (root.left != null)
            {
                isLeftValidBST = (root.left.val < root.val ) && IsValidLeftBST(root.left, root.val);
            }

            if (root.right != null)
            {
                isRightValidBST = (root.right.val > root.val ) && IsValidRightBST(root.right, root.val);
            }

            return isLeftValidBST && isRightValidBST;
        }

        private bool IsValidRightBST(TreeNode root, int benchmark)
        {
            if (root == null) return false;
            bool isLeftValidBST = true;
            bool isRightValidBST = true;
            if (root.left != null)
            {
                isLeftValidBST = (root.left.val < root.val && root.left.val > benchmark) && (IsValidLeftBST(root.left, root.val));
            }

            if (root.right != null)
            {
                isRightValidBST = (root.right.val > root.val) && (IsValidRightBST(root.right, root.val));
            }

            return isLeftValidBST && isRightValidBST;
        }
        
        private bool IsValidLeftBST(TreeNode root, int benchmark)
        {
            if (root == null) return false;
            bool isLeftValidBST = true;
            bool isRightValidBST = true;
            if (root.left != null)
            {
                isLeftValidBST = (root.left.val < root.val) && (IsValidLeftBST(root.left, root.val));
            }

            if (root.right != null)
            {
                isRightValidBST = (root.right.val > root.val && root.right.val < benchmark) && (IsValidRightBST(root.right, root.val));
            }

            return isLeftValidBST && isRightValidBST;
        }
    }
}