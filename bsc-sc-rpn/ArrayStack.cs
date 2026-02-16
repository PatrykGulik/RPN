using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Patryk Gulik
 * 11002010
 * Class: ArrayStack
 * Implements IStack<T>
 * Stores elements in an array 
 */

namespace bsc_sc_rpn
{

    // Class decalaration - generic, works with any type
    public class ArrayStack<T> : IStack<T>
    {
        private T[] items;
        private int _top = 0;

        // Constructor
        public ArrayStack(int capacity) 
        {
            items = new T[capacity];
        }

        // Push operation
        public void Push(T item)
        {
            if (_top >= items.Length)
            {
                throw new InvalidOperationException("Stack is full");
            }
            _top++;
            items[_top] = item;
          
        }

        // Pop operation
        public T Pop()
        {
            if (IsEmpty())
            {
                throw new IndexOutOfRangeException("Invalid index");
            }

            T item = items[_top];
            _top--; 
            return item;
        }

        // Peek operation
        public T Peek()
        {
            if (IsEmpty())
            {
                throw new IndexOutOfRangeException("Invalid index");
            }
            return items[_top];
        }

        // Checks if stack is empty 
        public bool IsEmpty()
        {
            return items.Length == 0;
        }
    }
}
