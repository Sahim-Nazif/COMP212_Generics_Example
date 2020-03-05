using System;
using System.Collections.Generic;
using System.Text;

namespace COMP212_Generic_Example
{
    //using non-generic class and methods
    public class CompareClass
    {
        public bool Compare(string a, string b)
        {
            if (a.Equals(b))
                return true;
            else
                return false;
        }
        public bool Compare(int a, int b)
        {
            if(a.Equals(b))
                return true;
            else
                return false;
        }
    }
}
