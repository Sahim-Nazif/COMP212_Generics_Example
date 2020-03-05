using System;

namespace COMP212_Generic_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating object of non generic class
            CompareClass compareClass = new CompareClass();
            bool intResult = compareClass.Compare(5, 7);
            Console.WriteLine(intResult);
            bool stringResult = compareClass.Compare("One", "One");
            Console.WriteLine(stringResult);

            //creating objec of generic class
            CompareGenericClass<int> compareGeneric = new CompareGenericClass<int>();
            bool compareIntegers = compareGeneric.Compare(12, 18);
            Console.WriteLine(compareIntegers);
            CompareGenericClass<string> stringGeneric = new CompareGenericClass<string>();
            bool compareStrings = stringGeneric.Compare("Two", "Two");
            Console.WriteLine(compareStrings);

            Console.ReadLine();
        }
    }
}
