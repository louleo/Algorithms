using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DataStructure
{

    public interface IStack<T>
    {
        void Push(T item);

        T Pop();

        T Peek();

        void Clear();

        int Size();

    }


    public class StackBasedOnList<T> : IStack<T>
    {
        private List<T> _stack;

        public StackBasedOnList()
        {
            _stack = new List<T>();
        }

        public void Push(T item)
        {
            _stack.Add(item);
        }

        public T Pop()
        {
            var item = Peek();
            _stack.Remove(item);
            return item;
        }

        public T Peek()
        {
            return _stack[-1];
        }

        public void Clear()
        {
            _stack = new List<T>();
        }

        public int Size()
        {
            return _stack.Count;
        }
    }

    public class StackBasedOnArray<T> : IStack<T>
    {
        private T[] _stack;
        private int _capability = 10;
        private int _pointer = -1;

        public StackBasedOnArray()
        {
            _stack = new T[_capability];
        }

        public StackBasedOnArray(int capability): this()
        {
            _capability = capability;
        }


        public void Push(T item)
        {
            _pointer++;
            _stack[_pointer] = item;
        }

        public T Pop()
        {
            if (_pointer < 0)
            {
                throw new Exception();
            }
            int lastIndex = _pointer;
            _pointer--;
            return _stack[lastIndex];
        }

        public T Peek()
        {
            if (_pointer < 0)
            {
                throw new Exception();
            }
            return _stack[_pointer];
        }

        public void Clear()
        {
            _stack = new T[_capability];
            _pointer = -1;
        }

        public int Size()
        {
            return _pointer + 1;
        }
    }
}