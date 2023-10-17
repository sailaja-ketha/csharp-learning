using System.Collections;
namespace Collections
{
    class NonGenericCollections
    {
        //An ArrayList can be used to add unknown data where you don't know the types and the size of the data
        public static void ArrayList()
        {
            // Create an ArrayList.
            ArrayList numbers = new ArrayList();

            // Add elements to the ArrayList.
            numbers.Add(10);
            numbers.Add(20);
            numbers.Add(30);
            numbers.Add(40);
            numbers.Add("Sailu");

            // Access elements by index.
            Console.WriteLine("Element at index 0: " + numbers[0]);

            // Modify an element.
            numbers[1] = 25;

            // Remove an element .
            numbers.RemoveAt(2);

            // Iterate through the ArrayList.
            Console.WriteLine("//Elements in the ArrayList://");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            ArrayList arlist = new ArrayList();
            arlist.Add(100);
            arlist.Add("ArrayList");
            arlist.Add(" ");
            arlist.Add('s');
            arlist.Add(true);
            arlist.Add(4.5);
            arlist.Add(null);

            //Use the AddRange(ICollection c) method to add an entire Array,
            //HashTable, SortedList, ArrayList, BitArray, Queue, and Stack in the ArrayList

            int[] arr = { 100, 200, 300, 400 };

            Queue myQ = new Queue();
            myQ.Enqueue("Hello");
            myQ.Enqueue("World!");

            arlist.AddRange(arr); //adding array in arraylist 
            arlist.AddRange(myQ); //adding Queue in arraylist 

            //accessing an element
            Console.WriteLine("Element at index 0: " + arlist[1]);

            //iterate elements
            Console.WriteLine("//arraylist elements: //");
            foreach (var item in arlist)
            {
                Console.WriteLine(item);
            }

            //Use the Insert() method to insert an element at the specified index into an ArrayList

            arlist.Insert(1, "Sailaja");

            Console.WriteLine("//After inserting//");
            foreach (var val in arlist)
            {
                Console.WriteLine(val);
            }

            arlist.Remove(null); //Removes first occurance of null
            arlist.RemoveAt(4); //Removes element at index 4
            arlist.RemoveRange(0, 2);//Removes two elements starting from 1st item (0 index)

            Console.WriteLine("//After Removing//");
            foreach (var val in arlist)
            {
                Console.WriteLine(val);
            }

            //contains method will check wether the specific element is exist in arraylist or not

            Console.WriteLine(arlist.Contains("ArrayList"));
        }

        public static void HashTable()
        {
            //A hash table data structure is made up of key-value pairs.
            //The hash values of the keys are compared to find the values.
            //It offers functions that are comparable to those in the generic dictionary class

            Hashtable NonGenericHashTable = new Hashtable();

            NonGenericHashTable.Add(1, "AndhraPradesh");

            NonGenericHashTable.Add(2, "Hyderabad");

            NonGenericHashTable.Add(3, "Gujarath");

            NonGenericHashTable.Add(4, "Vizag");

            //Elements are stored as DictionaryEntry objects

            foreach (DictionaryEntry h in NonGenericHashTable)
            {

                Console.WriteLine(h.Key + " " + h.Value);

            }

            //another example

            var cities = new Hashtable()
            {
            {"UK", "London, Manchester, Birmingham"},
            {"USA", "Chicago, New York, Washington"},
            {"India", "Mumbai, New Delhi, Pune"}
            };


            foreach (DictionaryEntry h in cities)
            {

                Console.WriteLine(h.Key + " " + h.Value);

            }
            Console.WriteLine("Total Elements: {0}", cities.Count);

            cities.Remove("UK");

            Console.WriteLine("Total Elements: {0}", cities.Count);

            if (cities.ContainsKey("France"))
            { 
                cities.Remove("France");
            }

            cities.Clear(); 
            Console.WriteLine("Total Elements after Clear(): {0}", cities.Count);

        }

        public static void SortedList()
        {
            SortedList NonGenericSortedList = new SortedList();

            NonGenericSortedList.Add("Magic", "Wings");

            NonGenericSortedList.Add("Butter", "Nan");

            NonGenericSortedList.Add("French", "Fries");

            NonGenericSortedList.Add("Onion", "Fry");

            foreach (DictionaryEntry d in NonGenericSortedList)
            {

                Console.WriteLine(d.Key + " " + d.Value);

            }
        }

        public static void Stack()
        {
            //It's a FIFO (first-in, first-out) list.
            //Hence it works similarly to the Stack class in generic collections

            Stack stack = new Stack();

            stack.Push("MARUTHI");

            stack.Push("BMW");

            stack.Push("FERARI");

            stack.Push("BENZ");

            foreach (var item in stack)
            {

                Console.WriteLine(item);
            }
        }

        public static void Queue() 
        {
            Queue NonGenericQueue = new Queue();

            NonGenericQueue.Enqueue("alphabets");

            NonGenericQueue.Enqueue("Numbers");

            NonGenericQueue.Enqueue("Special Characters");

            foreach (var item in NonGenericQueue)
            {

                Console.WriteLine(item);

            }

        }
    }

}
