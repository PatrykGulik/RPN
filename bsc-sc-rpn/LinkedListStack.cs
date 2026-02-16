using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bsc_sc_rpn
{
    public class LinkedListStack<T> : IStack<T>
    {

        private Node top;
        public class Node {

            public T data { get; set; }
            public Node next { get; set; }

            public Node(T items) { 
                data = items;
                next = null;

            }               
        }

        public LinkedListStack() 
        {
            top = null;
        }

        public void Push(T item)
        {
            Node temp = new Node(item);
            temp.next = top;
            top = temp;
        }

        public T Pop()
        {
            if (IsEmpty())
            {
                throw new IndexOutOfRangeException("Invalid index");
            }

            T item = top.data;
            top = top.next;
            return item;
        }

        public T Peek()
        {
            if (IsEmpty())
            {
                throw new IndexOutOfRangeException("Invalid index");
            }
            return top.data;
        }

        public bool IsEmpty()
        {
            return top == null;
        }


        
    }
}
