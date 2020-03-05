using System;
using System.Collections.Generic;
using System.Text;

namespace COMP212_Generic_Example
{
    public class CompareGenericClass<T>
    {
        public bool Compare(T a, T b)
        {
            if (a.Equals(b))
                return true;
            else
                return false;
        }
     }
}
