using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class FixedList<T>
    {
        private T[] items;
        private int count;

        public FixedList(int capacity)
        {
            if (capacity <= 0)
                throw new ArgumentException("Capacity must be greater than 0!");
            items = new T[capacity];
            count = 0;
        }

        public void Add(T item)
        {
            if (count >= items.Length)
                throw new InvalidOperationException("Can't add more items, List is full!");
            items[count] = item;
            count++;
        }

        public T Get(int index)
        {
            if (index < 0 || index >= count)
                throw new IndexOutOfRangeException("Index out of range!");
            return items[index];
        }
    }
}
