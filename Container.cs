using System;
using System.Collections.Generic;
using System.Text;

namespace OOPAdvanced01
{
    internal class Container<T>
    {
        private List<T> items = new List<T>();

        // Add this property to make the count public
        public int Count
        {
            get { return items.Count; }
        }

        public void Add(T item)
        {
            items.Add(item);
        }

        public T Get(int index)
        {
            return items[index];
        }
    }

}
