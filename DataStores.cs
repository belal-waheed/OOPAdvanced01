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
}
