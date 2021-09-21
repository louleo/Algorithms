using System;
using System.Collections.Generic;

namespace DataStructure
{
    class SinglyLinkedListNode<T>
    {
        public T Value { get; set; }
        public SinglyLinkedListNode<T>? Next { get; set; }

        public SinglyLinkedListNode(T value)
        {
            Value = value;
            Next = null;
        }
    }
    
    public class SinglyLinkedList<T>
    {
        
    }

}