using System.Collections.Generic;

namespace DataStructure
{
    public interface IQueue<T>
    {
        void Add(T item);
        T Remove();
        T Peek();
        T Front();
        void Clear();
        int Size();
    }
    
    public class Queue<T>: IQueue<T>
    {
        private List<T> _queue;

        public Queue()
        {
            _queue = new List<T>();
        }

        public void Add(T item)
        {
            _queue.Add(item);
        }

        public T Remove()
        {
            T item = Front();
            _queue.Remove(item);
            return item;
        }

        public T Peek()
        {
            return _queue[-1];
        }

        public T Front()
        {
            return _queue[0];
        }

        public void Clear()
        {
            _queue = new List<T>();
        }

        public int Size()
        {
            return _queue.Count;
        }
    }
}