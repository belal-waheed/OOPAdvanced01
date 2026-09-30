using System;
using System.Collections.Generic;
using System.Text;

namespace OOPAdvanced01
{
    internal class Pair<TKey, TValue>
    {
        public TKey Key { get; set; }
        public TValue Value { get; set; }
    }

}
