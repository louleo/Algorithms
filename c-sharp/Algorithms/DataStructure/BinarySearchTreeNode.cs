using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;

namespace DataStructure
{
    public class BinarySearchTreeNode: BinaryTreeNode<int>
    {
        public BinarySearchTreeNode Right { get; set; }

        public BinarySearchTreeNode Left { get; set; }
        
        public BinarySearchTreeNode Parent { get; set; }

        public bool IsRoot => Parent is null;
        public BinarySearchTreeNode(int value):base(value)
        {
        }

        public void InsertNode(int value)
        {
            if (value > Value)
            {
                if (Right is null)
                {
                    Right = new BinarySearchTreeNode(value);
                    Right.Parent = this;
                }
                else
                {
                    Right.InsertNode(value);
                }
            }
            else
            {
                if (Left is null)
                {
                    Left = new BinarySearchTreeNode(value);
                    Left.Parent = this;
                }
                else
                {
                    Left.InsertNode(value);
                }
            }
        }

        public BinarySearchTreeNode SearchNode(int value)
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

        public bool IsLeft()
        {
            return Parent?.Left?.Value == Value;
        }

        public bool IsRight()
        {
            return Parent?.Right?.Value == Value;
        }

        public void WriteToList(IList<int> results)
        {
            Left?.WriteToList(results);
            results.Add(Value);
            Right?.WriteToList(results);
        }
    }
}