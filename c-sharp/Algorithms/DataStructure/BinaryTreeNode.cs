namespace DataStructure
{
    public class BinaryTreeNode<T>
    {
        public virtual BinaryTreeNode<T>? Left { get; set; }
        public virtual BinaryTreeNode<T>? Right { get; set; }

        public bool IsRoot => Parent is null;

        public T Value { get; set; }
        public virtual BinaryTreeNode<T>? Parent { get; set; }

        public BinarySearchTree(T value)
        {
            Value = value;
        }
    }
}