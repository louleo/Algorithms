using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace LeetCode
{

    public class LinkedListNode
    {
        private LinkedListNode _prev;
        private LinkedListNode _next;
        private int _value;

        public LinkedListNode(int value)
        {
            _value = value;
        }

        public void AddPrev(LinkedListNode prev)
        {
            _prev = prev;
        }

        public void AddNext(LinkedListNode next)
        {
            _next = next;
        }

        public LinkedListNode GetNext()
        {
            return _next;
        }

        public LinkedListNode GetPrev()
        {
            return _prev;
        }
    }


    public class LinkedList
    {
        private LinkedListNode _head = null;
        private LinkedListNode _tail = null;
        private int _capacity;
        private int _count;

        public LinkedList(int capacity)
        {
            _capacity = capacity;
            _count = 0;
        }

        public bool Append(LinkedListNode nodeToAdd)
        {
            if (this._count == this._count)
            {
                return false;
            }

            if (this._head is null)
            {
                this._head = nodeToAdd;
                this._tail = nodeToAdd;
                this._count = 1;
                return true;
            }

            nodeToAdd.AddPrev(this._tail);
            this._tail.AddNext(nodeToAdd);
            this._tail = nodeToAdd;
            _count += 1;
            return true;
        }

        public bool RemoveFirst()
        {
            if (this._head is null)
            {
                return false;
            }

            if (this._count == 1)
            {
                this._head = null;
                this._tail = null;
                this._count = 0;
            }

            LinkedListNode nodeToRemove = this._head;
            this._head = this._head.GetNext();
            this._head.AddPrev(null);
            nodeToRemove.AddNext(null);
            _count--;
            return true;
        }
    }

    public class KeyValuePair
    {
        public int Key;
        public int Value;

        public KeyValuePair(int key, int value)
        {
            Key = key;
            Value = value;
        }

        public override bool Equals(KeyValuePair? keyValuePair)
        {
            return base.Equals(obj);
        }
    }
    
    public class LRUCacheSolution
    {
        private Dictionary<int, LinkedListNode<KeyValuePair>> _cache;
        private LinkedList<KeyValuePair> _list;
        private int _capacity;

        public LRUCacheSolution(int capacity)
        {
            this._capacity = capacity;
            this._list = new LinkedList<KeyValuePair>();
            this._cache = new Dictionary<int, LinkedListNode<KeyValuePair>>();
        }

        public int Get(int key)
        {
            LinkedListNode<KeyValuePair> node;
            if (_cache.TryGetValue(key, out node))
            {
                ReorderList(node);
                return node.Value.Value;
            }
            return -1;
        }

        public void Put(int key, int value)
        {
            LinkedListNode<KeyValuePair> node = new LinkedListNode<KeyValuePair>(new KeyValuePair(key, value));
            if (_cache.TryAdd(key, node))
            {
                if (_cache.Count > _capacity)
                {
                    _cache.Remove(_list.First.Value.Key);
                    _list.RemoveFirst();
                }
                
            }
            else
            {
                _cache[key] = node;
                ReorderList(node);
            }
        } 


        private void ReorderList(LinkedListNode<KeyValuePair> node)
        {
            
            _list.AddLast(node);
        }

    }
}