using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Transactions;

namespace LeetCode
{

    public class LinkedListNode
    {
        public int Value;
        public int Key;
        public LinkedListNode PrevNode;
        public LinkedListNode NextNode;

        public LinkedListNode(int key, int value)
        {
            Key = key;
            Value = value;
        }

        public LinkedListNode()
        {
            
        }
    }
    
    public class LRUCache
    {
        private Dictionary<int, LinkedListNode> _cache;
        private int _capacity;
        private LinkedListNode _head;
        private LinkedListNode _tail;

        public LRUCache(int capacity)
        {
            this._capacity = capacity;
            this._cache = new Dictionary<int, LinkedListNode>();
            this._head = new LinkedListNode();
            this._tail = new LinkedListNode();
            _tail.PrevNode = _head;
            _head.NextNode = _tail;
        }

        public int Get(int key)
        {
            LinkedListNode node;
            if (_cache.TryGetValue(key, out node))
            {
                MoveNodeToLast(node);
                return node.Value;
            }
            return -1;
        }

        public void Put(int key, int value)
        {
            LinkedListNode node = new LinkedListNode(key, value);
            if (_cache.TryAdd(key, node))
            {
                AddNodeToLast(node);

                if (_cache.Count > _capacity)
                {
                    _cache.Remove(_head.NextNode.Key);
                    RemoveNode(_head.NextNode);
                }

            }
            else
            {
                _cache[key].Value = value;
                MoveNodeToLast(_cache[key]);
            }
        } 


        private void RemoveNode(LinkedListNode node)
        {
            node.PrevNode.NextNode = node.NextNode;
            node.NextNode.PrevNode = node.PrevNode;
        }


        private void AddNodeToLast(LinkedListNode node)
        {
            node.NextNode = _tail;
            node.PrevNode = _tail.PrevNode;
            _tail.PrevNode.NextNode = node;
            _tail.PrevNode = node;
        }

        private void MoveNodeToLast(LinkedListNode node)
        {
            RemoveNode(node);
            AddNodeToLast(node);
        }
        
    }
}