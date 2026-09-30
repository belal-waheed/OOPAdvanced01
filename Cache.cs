#nullable disable
using System;
using System.Collections.Generic;

namespace OOPAdvanced01
{
    //  Q19 
    public class BaseBox<T>
    {
        public T Item { get; set; }
    }

    //inhirit 
    public class GenericChildBox<T> : BaseBox<T> { }
    public class StringBox : BaseBox<string> { }


    //  Q20  
    public class Cache<TKey, TValue>
    {
        // Now the helper class holds the Key, Value, and Expiration Time
        private class CacheItem
        {
            public TKey Key { get; set; }
            public TValue Value { get; set; }
            public DateTime ExpirationTime { get; set; }
        }

        private List<CacheItem> storage = new List<CacheItem>();

        public void Add(TKey key, TValue value, TimeSpan lifespan)
        {
            // First, remove the old one if it already exists
            Remove(key);

            CacheItem newItem = new CacheItem();
            newItem.Key = key;
            newItem.Value = value;
            newItem.ExpirationTime = DateTime.Now.Add(lifespan);

            storage.Add(newItem);
        }

        public bool Contains(TKey key)
        {
            for (int i = 0; i < storage.Count; i++)
            {
                // We use .Equals() to compare generic types
                if (storage[i].Key.Equals(key))
                {
                    // If we found it, check if it expired!
                    if (DateTime.Now > storage[i].ExpirationTime)
                    {
                        storage.RemoveAt(i); // Delete the expired item
                        return false;
                    }
                    return true; // We found it and it is still alive
                }
            }
            return false;
        }

        public TValue Get(TKey key)
        {
            // If it exists (Contains also cleans it up if it expired)
            if (Contains(key))
            {
                // Loop through to find it and return the value
                for (int i = 0; i < storage.Count; i++)
                {
                    if (storage[i].Key.Equals(key))
                    {
                        return storage[i].Value;
                    }
                }
            }

            return default(TValue); // Return default if missing or expired
        }

        public void Remove(TKey key)
        {
            // Loop through and delete the item if the key matches
            for (int i = 0; i < storage.Count; i++)
            {
                if (storage[i].Key.Equals(key))
                {
                    storage.RemoveAt(i);
                    break; // Stop looking after we delete it
                }
            }
        }
    }
}