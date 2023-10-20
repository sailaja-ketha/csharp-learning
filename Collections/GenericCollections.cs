using System.Collections.Generic;
namespace Collections
{ 
    class GenericCollections
    {
        //The List<T> is a collection of strongly typed objects
        //that can be accessed by index and having methods for sorting, searching, and modifying list
        public static void List()
        {
            Console.WriteLine("Working with List");
            List<string> subjects = new List<string>() {"English","Science","Maths","Social"};
            subjects.Add("Hindi");
            subjects.Add("Chemistry");

            for(int i = 0; i < subjects.Count; i++)
            {
                Console.WriteLine(subjects[i]);
            }

            Console.WriteLine("Accessing element using index : " + subjects[3]);
            Console.WriteLine("Get length of the list : " + subjects.Count);

            //using insert method we can add element at particular index
            subjects.Insert(1, "Telugu");

            foreach(string subject in subjects)
            {
                Console.WriteLine(subject);
            }

            Console.WriteLine("Checking wether the element is present or not " + subjects.Contains("Hindi"));
            Console.WriteLine("Removing 1st element in list : " + subjects.Remove("Hindi"));
            Console.WriteLine("Removing particular element in list using index: " );
            subjects.RemoveAt(2);

            Console.WriteLine("After removing");
            for( int i = 0;i < subjects.Count;i++)
            {
                Console.WriteLine((i+1) + " " + subjects[i]);
            }

            subjects.Sort();
            Console.WriteLine("After sorting : ");
            foreach(string subject in subjects)
            {
                Console.WriteLine(subject);
            }

            subjects.Clear();

            Console.WriteLine("After Removing elements : ");
            for (int i= 0; i< subjects.Count; i++)
            {
                Console.WriteLine(subjects[i]);
            }



        }

        
        //a dictionary is a collection of key-value pairs that can be used to store and retrieve data efficiently.
        //Each key in the dictionary must be unique, and you can use the key to look up its corresponding value
        public static void Dictionary()
        {
            Dictionary<int, string> employeeDictionary = new Dictionary<int, string>();

            //add elements using add method
            employeeDictionary.Add(101, "Sailaja");
            employeeDictionary.Add(106, "Divya");
            employeeDictionary.Add(103, "Leela");
            employeeDictionary.Add(104, "Supriya");
            employeeDictionary.Add(105, "Bharathi");
            employeeDictionary.Add(102, "Venu");

            employeeDictionary.ContainsKey(105);

            Console.WriteLine("All Employees:");
            foreach (var key in employeeDictionary)
            {
                Console.WriteLine($"Employee ID {key.Key}: {key.Value}");
            }

           // Access using index
            string name = employeeDictionary[102];
            Console.WriteLine($"name with key 102: {name}");

            // Checking for key existence
            bool containsKey = employeeDictionary.ContainsKey(104);
            Console.WriteLine($"Key 104 exists: {containsKey}");

            // Removing key-value pairs

            employeeDictionary.Remove(106);

            Console.WriteLine("Count of the elements : " + employeeDictionary.Count);


        }

        //SortedList<TKey, TValue> is a generic collection that maintains a sorted order of key-value pairs
        //based on the keys. It provides efficient key-based retrieval and supports operations
        //like adding, updating, and removing elements while keeping the keys in sorted order
        public static void SortedList()
        {
            SortedList<int,string> fruits= new SortedList<int,string>();
            fruits.Add(1, "Banana");
            fruits.Add(4, "Apple");
            fruits.Add(3, "Grapes");
            fruits.Add(2, "Mango");
            fruits.Add(5, "orange");

            for(int i = 1; i < fruits.Count; i++)
            {
                Console.WriteLine(fruits[i]);
            }

            // Access using index
            string fruitName = fruits[2];
            Console.WriteLine($"name with key 102: {fruitName}");

            // Checking for key existence
            bool containsKey = fruits.ContainsKey(4);
            Console.WriteLine($"Key 4 exists: {containsKey}");

            // Removing key-value pairs
            fruits.Remove(5);

            Console.WriteLine("Count of the elements : " + fruits.Count);

            fruits.Clear();
            Console.WriteLine("After removing : ");
            Console.WriteLine("Count of the elements : " + fruits.Count);


            SortedList<int, string> sortedList = new SortedList<int, string>();

            sortedList.Add(3, "Three");
            sortedList.Add(1, "One");
            sortedList.Add(2, "Two");

            // Elements will be automatically sorted based on keys.
            foreach (var kvp in sortedList)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
            
        }

        //HashSet<T> Collection Class in C# can be used to store, remove or view elements.
        //It does not allow the addition of duplicate elements it will store only unique elements
        public static void HashSet()
        {
            HashSet<int> numbers= new HashSet<int>();
            numbers.Add(1000);
            numbers.Add(1001);
            numbers.Add(1002);
            numbers.Add(1003);
            numbers.Add(1004);
            numbers.Add(1005);

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }


        }


        //These collections implement a first-in, first-out (FIFO) data structure, respectively.
        //They are often used for managing work items or processing data
        public static void Queue()
        {
            Queue<string> countries = new Queue<string>();
            countries.Enqueue("India");
            countries.Enqueue("USA");
            countries.Enqueue("UK");
            countries.Enqueue("China");
            countries.Enqueue("Nepal");

            Console.WriteLine("Queue Elements: ");
            foreach (string country in countries)
            {
                Console.Write($"{country} ");
            }

            Console.WriteLine("\nElement Removed: " + countries.Dequeue());
            Console.WriteLine("Queue Elements: ");
            foreach (string country in countries)
            {
                Console.Write($"{country} ");
            }
            
        }


        //last in first out 
        public static void Stack()
        {
            Stack<char> alphabets = new Stack<char>();
            alphabets.Push( 'a' );
            alphabets.Push('b');
            alphabets.Push('c');
            alphabets.Push('d');
            alphabets.Push('e');
            alphabets.Push('f');

            Console.WriteLine("\n");
            foreach (char c in alphabets)
            {
                Console.WriteLine(  c);
            }

            char poppedItem = alphabets.Pop();

            Console.WriteLine("Popped item: " + poppedItem);
           
            foreach (char c in alphabets)
            {
                Console.WriteLine(c);
            }
        }


        //It is same like dictionary sorted dictionary to store sorted key value pairs 
        //It contains unique keys
        //and the most important thing is it stored the elements in ascending order on the key.
        public static void SortedDictionary()
        {
            SortedDictionary<int, string> sortedDictionary = new SortedDictionary<int, string>();
            sortedDictionary.Add(1, "One");
            sortedDictionary.Add(5, "Five");
            sortedDictionary.Add(2, "Two");
            sortedDictionary.Add(4, "Four");
            sortedDictionary.Add(3, "Three");

            Console.WriteLine("SortedDictionary Elements: ");
            foreach (var kvp in sortedDictionary)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }
        }


        //linked list 
        //It allows us to insert and delete elements fastly. It can have duplicate elements
        //It allows us to add and remove elements before or after the last index

        public static void LinkedList()
        {
            LinkedList<string> linkedList = new LinkedList<string>();
            linkedList.AddLast("One");
            linkedList.AddLast("Two");
            linkedList.AddLast("Three");
            linkedList.AddLast("Four");
            linkedList.AddFirst("Five"); //Added to first index

            Console.WriteLine("SortedDictionary Elements: ");
            foreach (var item in linkedList)
            {
                Console.WriteLine($"{item} ");
            }
        }


        //It is used to store, remove or view elements.
        //By default, it stores the elements in ascending order and does not store duplicate elements.
        //It is recommended to use if you have to store unique elements
        //as well as if you want to maintain ascending order

        public static void SortedSet()
        {
            SortedSet<int> integerSortedSet = new SortedSet<int>();
            integerSortedSet.Add(11);
            integerSortedSet.Add(66);
            integerSortedSet.Add(55);
            integerSortedSet.Add(88);
            integerSortedSet.Add(22);
            integerSortedSet.Add(77);

            //Addind Duplicate Elements
            integerSortedSet.Add(55);


            Console.WriteLine("List of Elements of SortedSet:");
            foreach (int item in integerSortedSet)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
