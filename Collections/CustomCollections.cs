using System;
using System.Collections.Generic;

namespace Collections
{ 
    class CustomCollections
    {
        //ICollection is an interface that contains size, enumerations, and synchronization methods
        //for all nongeneric collections.
        public static void Icollection()
        {
            ICollection<string> days = new List<string>();
            days.Add("MONDAY");
            days.Add("TUESDAY");
            days.Add("WEDNESDAY");
           
            foreach (var day in days)
            {
                Console.WriteLine(day);
            }

            days.Remove("WEDNESDAY");

            // Check the count of books in the collection
            int daysCount = days.Count;
            Console.WriteLine($"Number of days: {daysCount}");
        }


        //IEnumerable in C# is an interface that defines one method,
        //GetEnumerator which returns an IEnumerator interface.
        //This allows readonly access to a collection
        //then a collection that implements IEnumerable can be used with a for-each statement
        public static void Ienumerable()
        {
            
            int[] numbers = { 1, 2, 3, 4, 5 };

            // Use IEnumerable to iterate through the array
            IEnumerable<int> numberEnumerable = numbers;

            // Get an IEnumerator to iterate through the collection
            IEnumerator<int> enumerator = numberEnumerable.GetEnumerator();

            // to iterate through the collection
            while (enumerator.MoveNext())
            {
                int number = enumerator.Current;
                Console.WriteLine(number);
            }

            // Reset the enumerator to the beginning
            enumerator.Reset();

          
            foreach (int number in numberEnumerable)
            {
                Console.WriteLine(number);
            }
        
        }

        //IList is an interface that represents a collection of objects in an ordered manner.
        //It allows you to access elements by index, add, remove, or modify items in the collection
        public static void Ilist()
        {
            
            IList<int> numbers = new List<int>();

           
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);

            // Access elements by index
            int firstNumber = numbers[0];
            Console.WriteLine($"First number: {firstNumber}");

            // Modify an element
            numbers[1] = 42;

            // Remove an element
            numbers.RemoveAt(2); 

            // Check if an element exists in the list
            bool containsNumber = numbers.Contains(42);
            Console.WriteLine($"Does the list contain 42? {containsNumber}");

            // Get the number of elements in the list
            int count = numbers.Count;
            Console.WriteLine($"Number of elements in the list: {count}");

            // Iterate through the list
            Console.WriteLine("Numbers in the list:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }


        public static void Idictionary()
        {
            IDictionary<string, int> books = new Dictionary<string, int>();
            books.Add("Bhagvathgeeth", 25);
            books.Add("Ramayanam", 30);

            foreach(var number in books)
            {
                Console.WriteLine(number);
            }
        }

    }
}
