using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Patryk Gulik
 * 11002010
 * Class: LinkedListStack
 * Implements IStack<T>
 * Stores elements dynamically 
 */

namespace bsc_sc_rpn
{

    // Class decalaration - generic, works with any type
    public class LinkedListStack<T> : IStack<T>
    {

        // Reference to the top node
        private Node _top;

        // Node structure
        public class Node {

            public T data { get; set; }
            public Node next { get; set; }

            public Node(T items) { 
                data = items;
                next = null;

            }               
        }

        // Constructor
        public LinkedListStack() 
        {
            _top = null;
        }

        // Push operation
        public void Push(T item)
        {
            Node temp = new Node(item);
            temp.next = _top;
            _top = temp;
        }

        // Pop operation
        public T Pop()
        {
            if (IsEmpty())
            {
                throw new IndexOutOfRangeException("Invalid index");
            }

            T item = _top.data;
            _top = _top.next;
            return item;
        }

        // Peek operation
        public T Peek()
        {
            if (IsEmpty())
            {
                throw new IndexOutOfRangeException("Invalid index");
            }
            return _top.data;
        }

        // Checks if stack is empty
        public bool IsEmpty()
        {
            return _top == null;
        }


        
    }
}
