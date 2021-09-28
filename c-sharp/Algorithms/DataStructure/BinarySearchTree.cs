using System;
using System.Collections.Generic;

namespace DataStructure
{
    public class BinarySearchTree
    {
        private BinarySearchTreeNode _rootNode;

        public BinarySearchTree(int value)
        {
            _rootNode = new BinarySearchTreeNode(value);
        }

        public BinarySearchTree(int[] arr)
        {
            _rootNode = new BinarySearchTreeNode(arr[0]);
            for (int i = 1; i < arr.Length; i++)
            {
                _rootNode.InsertNode(arr[i]);
            }
        }

        public void Insert(int value)
        {
            _rootNode.InsertNode(value);
        }

        public void Delete(int value)
        {
            var nodeToDelete = SearchNode(value);
            if (nodeToDelete is null)
            {
                return;
            }

            //no left child, no right child, remove all its connection
            if (nodeToDelete.Left == null && nodeToDelete.Right == null)
            {
                if (nodeToDelete.IsRoot)
                {
                    _rootNode = null;
                    return;
                }

                if (nodeToDelete.IsLeft())
                {
                    nodeToDelete.Parent.Left = null;
                    return;
                }

                if (nodeToDelete.IsRight())
                {
                    nodeToDelete.Parent.Right = null;
                    return;
                }
            }

            //has right child, no left child, move its right child to replace its place
            if (nodeToDelete.Left == null && nodeToDelete.Right != null)
            {
                if (nodeToDelete.IsRoot)
                {
                    _rootNode = nodeToDelete.Right;
                    return;
                }

                if (nodeToDelete.IsLeft())
                {
                    nodeToDelete.Parent.Left = nodeToDelete.Right;
                    return;
                }

                if (nodeToDelete.IsRight())
                {
                    nodeToDelete.Parent.Right = nodeToDelete.Right;
                    return;
                }
            }

            //no right child, has left child, move its left child to replace its place
            if (nodeToDelete.Right == null && nodeToDelete.Left != null)
            {
                if (nodeToDelete.IsRoot)
                {
                    _rootNode = nodeToDelete.Left;
                }

                if (nodeToDelete.IsLeft())
                {
                    nodeToDelete.Parent.Left = nodeToDelete.Left;
                    return;
                }

                if (nodeToDelete.IsRight())
                {
                    nodeToDelete.Parent.Right = nodeToDelete.Left;
                    return;
                }
            }

            //has both children, find the 
            BinarySearchTreeNode firstLeftRightestNode;

            firstLeftRightestNode = nodeToDelete.Left;
            while (firstLeftRightestNode.Right != null)
            {
                firstLeftRightestNode = firstLeftRightestNode.Right;
            }

            if (firstLeftRightestNode.Left is null)
            {
                firstLeftRightestNode.Parent = nodeToDelete.Parent;
                firstLeftRightestNode.Right = nodeToDelete.Right;
                firstLeftRightestNode.Left = nodeToDelete.Left;
                if (nodeToDelete.IsLeft())
                {
                    nodeToDelete.Parent.Left = firstLeftRightestNode;
                    return;
                }

                if (nodeToDelete.IsRight())
                {
                    nodeToDelete.Parent.Right = firstLeftRightestNode;
                    return;
                }
            }
            else
            {
                firstLeftRightestNode.Parent.Right = firstLeftRightestNode.Left;
                firstLeftRightestNode.Parent = nodeToDelete.Parent;
                firstLeftRightestNode.Left = nodeToDelete.Left;
                firstLeftRightestNode.Right = nodeToDelete.Right;
                if (nodeToDelete.IsLeft())
                {
                    nodeToDelete.Parent.Left = firstLeftRightestNode;
                }

                if (nodeToDelete.IsRight())
                {
                    nodeToDelete.Parent.Right = firstLeftRightestNode;
                }
            }

        }

        public BinarySearchTreeNode Search(int value)
        {
            return SearchNode(value);
        }

        public bool Contains(int value)
        {
            return SearchNode(value) != null;
        }

        public IList<int> ToList()
        {
            List<int> results = new List<int>();
            _rootNode?.WriteToList(results);
            return results;
        }

        private BinarySearchTreeNode SearchNode(int value)
        {
            return _rootNode.SearchNode(value);
        }

    }
}