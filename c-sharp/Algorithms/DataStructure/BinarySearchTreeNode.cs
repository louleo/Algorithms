using System.Net.Http.Headers;

namespace DataStructure
{
    public class BinarySearchTreeNode<T>: BinaryTreeNode<T>
    {
        public override BinarySearchTreeNode<T>? Right { get; set; }

        public override BinarySearchTreeNode<T>? Left { get; set; }
        
        public override BinarySearchTreeNode<T>? Parent { get; set; }


        public void InsertNode(T value)
        {
            if (value > Value)
            {
                if (Right is null)
                {
                    Right = new BinarySearchTreeNode<T>(value);
                    Right.Parent = this;
                }
                else
                {
                    Right.InsertNode(T);
                }
            }
            else
            {
                if (Left is null)
                {
                    Left = new BinarySearchTreeNode<T>(value);
                    Left.Parent = this;
                }
                else
                {
                    Left.InsertNode(T);
                }
            }
        }

        public BinarySearchTree<T>? SearchNode(T value)
        {
            if (value == Value)
            {
                return this;
            }else if (value > Value)
            {
                return Right?.SearchNode(value);
            }
            else
            {
                return Left?.SearchNode(value);
            }
        }
    }
}