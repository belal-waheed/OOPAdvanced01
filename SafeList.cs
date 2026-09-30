using System;
using System.Collections.Generic;
using System.Text;

namespace OOPAdvanced01
{
    internal class SafeList<T>
    {
        private List<T> items = new List<T>();
        public void Add(T item)
        {
            items.Add(item);
        }
        public T? Get(int index)
        {
            // Check if the index is out of bounds
            if (index < 0 || index >= items.Count)
            {
                // Instead of crashing, safely return the default value for whatever T is!
                return default(T);
            }
            return items[index];
        }
    }
}
