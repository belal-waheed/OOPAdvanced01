using System;
using System.Collections.Generic;
using System.Text;

namespace OOPAdvanced01
{
    // Q7: Only accepts Value Types (like int, float, bool)
    public class ValueStore<T> where T : struct
    {
        public T Data { get; set; }
    }
    // Q8: Only accepts Reference Types (like string, or your own classes)
    public class ReferenceStore<T> where T : class
    {
        public T Data { get; set; }
    }

    // Q9 
    public class Factory<T> where T : new()
    {
        public T CreateInstance()
        {
            return new T(); // We can do this safely because of the new() constraint
        }
    }
    // Q10 
    public interface IPrintable
    {
        void Print();
    }
    public class Printer<T> where T : IPrintable
    {
        public void PrintItem(T item)
        {
            item.Print(); // We can call this safely because of the IPrintable constraint
        }
    }
    // Q10: A class that implements IPrintable
    public class Document : IPrintable
    {
        public string Title { get; set; } = "Blank Document";
        
        // Fulfills the IPrintable requirement
        public void Print()
        {
            Console.WriteLine("Printing: " + Title);
        }
    }

}
