using System;
using System.Collections.Generic;
using System.Text;

namespace OOPAdvanced01
{
    public class Utility
    {
        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
        public static T FindMax<T>(T a, T b) where T : IComparable<T>
        {
            if (a.CompareTo(b) > 0)
            {
                return a;
            }
            return b;
        }
    }
}
