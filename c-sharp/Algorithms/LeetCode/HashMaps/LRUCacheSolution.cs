using System.Collections.Generic;

namespace LeetCode.HashMaps
{
    public class LRUCacheSolution
    {
        
    }

    class ListNode
    {
        public ListNode Prev { get; set; }
        public ListNode Next { get; set; }
        public int Value { get; set; }

        public int Key { get; set; }

        public ListNode(int key, int value)
        {
            Key = key;
            Value = value;
            Prev = null;
            Next = null;
        }

        public ListNode()
        {
            Prev = null;
            Next = null;
        }
    }
    
    class LRUCache
    {
        //a data structure which can easily maintain usage frequency 
        private int _capacity;
        private ListNode _head;
        private ListNode _tail;
        private Dictionary<int, ListNode> _dictionary;

        public LRUCache(int capacity)
        {
            _capacity = capacity;
            _head = new ListNode();
            _tail = new ListNode();
            _head.Next = _tail;
            _tail.Prev = _head;
            _dictionary = new Dictionary<int, ListNode>();
        }
    
        public int Get(int key)
        {
            ListNode node;
            if (_dictionary.TryGetValue(key, out node))
            {
                RemoveFromList(node);
                AddToHead(node);
                return node.Value;
            }
            else
            {
                return -1;
            }
        }
    
        public void Put(int key, int value)
        {
            ListNode node;
            if (_dictionary.TryGetValue(key, out node))
            {
                node.Value = value;
                RemoveFromList(node);
                AddToHead(node);
            }
            else
            {
                node = new ListNode(key, value);
                _dictionary.Add(key, node);
                AddToHead(node);
                while (_dictionary.Count > _capacity)
                {
                    ListNode nodeToRemove = _tail.Prev;
                    _dictionary.Remove(nodeToRemove.Key);
                    RemoveFromList(nodeToRemove);
                }
            }
        }

        private void RemoveFromList(ListNode node)
        {
            node.Prev.Next = node.Next;
            node.Next.Prev = node.Prev;
            node.Prev = null;
            node.Next = null;
        }

        private void AddToHead(ListNode node)
        {
            _head.Next.Prev = node;
            node.Next = _head.Next;
            node.Prev = _head;
            _head.Next = node;
        }
        
    }
}