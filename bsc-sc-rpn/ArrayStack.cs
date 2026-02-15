using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bsc_sc_rpn
{
    public class ArrayStack<T> : IStack<T>
    {
        private T[] items;
        private int top = 0;

        public ArrayStack(int capacity) 
        {
            items = new T[capacity];
        }

        public void Push(T item)
        {
            if (top >= items.Length)
            {
                throw new InvalidOperationException("Stack is full");
            }
            top++;
            items[top] = item;
          
        }
        public T Pop()
        {
            if (IsEmpty())
            {
                throw new IndexOutOfRangeException("Invalid index");
            }

            T item = items[top];
            top--; 
            return item;
        }

        public T Peek()
        {
            if (IsEmpty())
            {
                throw new IndexOutOfRangeException("Invalid index");
            }
            return items[top];
        }

        public bool IsEmpty()
        {
            return items.Length == 0;
        }
    }
}
