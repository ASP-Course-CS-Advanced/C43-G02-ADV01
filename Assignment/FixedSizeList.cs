using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class FixedSizeList<T>
    {

        #region Q05 - implement a custom list called FixedSizeList<T> with a predetermined capacity.
        
        #region Properties

        private T[] items;
        private int count;

        #endregion

        #region Constructors

        public FixedSizeList(int capacity)
        {
            if (capacity <= 0)
                throw new ArgumentException("Capacity must be greater than 0!");
            items = new T[capacity];
            count = 0;
        }

        #endregion

        #region Methods

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

        #endregion 

        #endregion

    }
}
