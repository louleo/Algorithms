using System;

namespace DataStructure
{
    public class BinarySearchTree<T>
    {
        private BinarySearchTreeNode<T> _rootNode;

        public BinarySearchTree(T value)
        {
            _rootNode = new BinarySearchTreeNode<T>(value);
        }

        public void InsertNode(T value)
        {
            _rootNode.InsertNode(value);
        }

        public void DeleteNode(T value)
        {
            var nodeToDelete = SearchNode(value);
            if (nodeToDelete is null)
            {
                return;
            }
            
        }

        public bool Contains(T value)
        {
            return SearchNode(value) != null;
        }

        public BinarySearchTreeNode<T>? SearchNode(T value)
        {
            return _rootNode.SearchNode(value);
        }

    }
}