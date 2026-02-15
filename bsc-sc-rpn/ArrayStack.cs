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
        private int currentIndex;

        public ArrayStack(int capacity) 
        {
            items = new T[capacity];
            currentIndex = 0;
        }

        public void Push(T item)
        {
            items[currentIndex++] = item;
        }
        public T Pop()
        {
            return items[currentIndex];
        }

        public T Peek()
        {
            return items[currentIndex];
        }

        public bool IsEmpty()
        {
            return items.Length == 0;
        }
    }
}
