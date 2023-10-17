// Collections

//C# includes specialized classes that store series of values or objects are called collections
using System.Collections;

namespace Collections
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Collections");
            Console.WriteLine("****ArrayList*****");
            NonGenericCollections.ArrayList();
            Console.WriteLine("***HashTable*****");
            NonGenericCollections.HashTable();
            Console.WriteLine("****SortedList*****");
            NonGenericCollections.SortedList();
            Console.WriteLine("****Stack*****");
            NonGenericCollections.Stack();
            Console.WriteLine("****Queue*****");
            NonGenericCollections.Queue();
        }

    }
}