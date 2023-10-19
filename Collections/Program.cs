// Collections

//C# includes specialized classes that store series of values or objects are called collections

//Collection classes are specialized classes for data storage and retrieval

//collection represents group of objects.
//By the help of collections, we can perform various operations on objects such as
//storing,retreiving,delete,update,sort

//2 types of collections
//1.generic collections 2.Nongeneric collections

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

            Console.WriteLine("--------Generic Collections--------");
            GenericCollections.List();
            GenericCollections.Dictionary();
            GenericCollections.SortedList();
            GenericCollections.HashSet();
            GenericCollections.Queue();
            GenericCollections.Stack();
            GenericCollections.SortedDictionary();
            GenericCollections.LinkedList();
            GenericCollections.SortedSet();

            Console.WriteLine("\n--------Custom Collections--------");
            CustomCollections.Icollection();
            CustomCollections.Ienumerable();
            CustomCollections.Ilist();
            CustomCollections.Idictionary();
        }

    }
}