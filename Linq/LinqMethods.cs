namespace Linq
{
    public class LinqMethods
    {

        //where method is used to filter the elements in collection which satisfies the condition
        public static void Where()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> evenNumbers = numbers.Where(n => n % 2 == 0).ToList();
            foreach (var n in evenNumbers)
            {
                Console.WriteLine(n);
            }
        }

        //Projects each element in a collection into a new form
        public static void Select()
        {
            List<string> names = new List<string> { "Bike", "car", "Auto" };
            var select = names.Select(n => n.StartsWith('B')).ToList();
            foreach (var n in select)
            {
                Console.WriteLine(n);
            }
            
        }


        //Returns the single element that satisfies a condition
        public static void Single()
        {
            List<string> days = new List<string> { "monday", "tuesday", "wednesday", "thursday" };
            Console.WriteLine("Enter name of the day");
            string nameOfDay = Console.ReadLine();
            string foundDay = days.Single(fruit => fruit == nameOfDay);
            if (foundDay != null)
            {
                Console.WriteLine($"Found a {nameOfDay} in the list.");
            }
            else
            {
                Console.WriteLine($"NotFound a {nameOfDay}  in the list.");
            }

        }

        //find a single element in a collection that matches a specified condition
        public static void SingleOrDefault()
        {
            List<string> fruits = new List<string> { "apple", "grapes", "banana", "orange" };
            Console.WriteLine("Enter name of the fruit");
            string nameOfFruit = Console.ReadLine();
            string foundFruit = fruits.SingleOrDefault(fruit => fruit == nameOfFruit);
            if (foundFruit != null)
            {
                Console.WriteLine($"Found a {nameOfFruit} in the list.");
            }
            else
            {
                Console.WriteLine($"No {nameOfFruit} found in the list.");
            }

        }


        //Returns the first element that satisfies a condition.
        public static void First()
        {
            List<string> animals = new List<string> { "monkey", "dog","fox", "camel", "lion" };
            Console.WriteLine("Enter name of the animal");
            string nameOfAnimal=Console.ReadLine();
            string foundAnimal = animals.First(animal => animal == nameOfAnimal);
            if (foundAnimal != null)
            {
                Console.WriteLine($"Found a {nameOfAnimal} in the list.");
            }
            else
            {
                Console.WriteLine($" {nameOfAnimal} not found");
            }
        }
        //Returns the first element that satisfies a condition or a default value if none is found.

        public static void  FirstOrDefault() 
        {
            List<int> evenNumbers = new List<int>() { 2, 4, 6, 8, 10 };
            Console.WriteLine("Enter Number");
            int number=Convert.ToInt32(Console.ReadLine());
            int result = evenNumbers.FirstOrDefault(num => num==number);
            Console.WriteLine(result);
        }

        //The All method checks if all elements in a collection satisfy a given condition.
        //It returns true if all elements meet the condition, otherwise, it returns false
        public static void All()
        {
            List<int> numbers = new List<int> { 1,2, 4, 6, 8, 10 };
            bool allEven = numbers.All(n => n % 2 == 0);
            if (allEven)
            {
                Console.WriteLine("All numbers are even.");
            }
            else
            {
                Console.WriteLine("All numbers are  not even.");
            }
        }


        //The Any method checks if any element in a collection satisfies a given condition.
        //It returns true if at least one element meets the condition, otherwise, it returns `false
        public static void Any()
        {
            List<int> numbers = new List<int> { 2, 4, 5, 7, 8, 10 };
            bool hasOddNumber = numbers.Any(n => n % 2 != 0);

            if (hasOddNumber)
            {
                Console.WriteLine("The list contains at least one odd number.");
            }
            else
            {
                Console.WriteLine("The list doesn't contain any odd numbers.");
            }
        }

        //The Find method returns the first element that satisfies the condition or,
        //if none is found, it returns the default value for the element type 
        public static void Find()
        {
            List<string> colors = new List<string>{ "Red", "Blue", "Green", "Yellow", "Orange", "Purple"};
            string colorStartingWithB = colors.Find(color => color.StartsWith('b'));

            if (colorStartingWithB != null)
            {
                Console.WriteLine($"First color starting with 'B': {colorStartingWithB}");
            }
            else
            {
                Console.WriteLine("No color starts with 'B' found.");
            }
        }

        //to group elements based on a specific key or property
        public static void GroupBy()
        {
            List<Person> people = new List<Person>
            {
            new Person { Name = "Sailaja", Age = 22 },
            new Person { Name = "Leela", Age = 23 },
            new Person { Name = "Divya", Age = 25 },
            new Person { Name = "Supriya", Age = 35 },
            new Person { Name = "venu", Age = 40 }
        };

            // Use GroupBy to group people by their age
            var groupedPeople = people.GroupBy(p => p.Age);

            
            foreach (var group in groupedPeople)
            {
                Console.WriteLine($"Age: {group.Key}");
                foreach (var person in group)
                {
                    Console.WriteLine($"- {person.Name}");
                }
                Console.WriteLine();
            }
        

    }
        //orderby method is used to return the elements in ascending order
        //orderbydescending is used to return the elements in descending order
        public static void OrderByMethods()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var sortedNumbers = numbers.OrderBy(n => n); // Ascending order
            var reverseSortedNumbers = numbers.OrderByDescending(n => n); // Descending order
            Console.WriteLine("Ascending order");
            foreach (var n in sortedNumbers)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine("Descending order");
            foreach (var n in reverseSortedNumbers)
            {
                Console.WriteLine(n);
            }

        }


        //to get sum of the elements in collection using sum method
        //get avg value of the collection average()
        //get count of the elements in collection count()
        public static void Aggreration()
        {
            List<double> numbers = new List<double> { 2.3,4.5,6.7,8.9 };
            double sum = numbers.Sum();
            Console.WriteLine(sum);
            double average = numbers.Average();
            Console.WriteLine(average);
            double count = numbers.Count();
            Console.WriteLine(count);
            double maxNum=numbers.Max();
            double minNum=numbers.Min();
            Console.WriteLine(minNum);
            Console.WriteLine(maxNum);

        }

        //to join two collections using concat() method

        public static void Concat()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> otherNumbers = new List<int> { 5, 6, 7, 8, 9, 10, 11, 12 };
            List<int> combinedNumbers = numbers.Concat(otherNumbers).ToList();
            foreach( var number in combinedNumbers )
            {
                Console.WriteLine(number);
            }

            //distinct method will filter the duplicated values
            List<int> distinctElements =combinedNumbers.Distinct().ToList();
            Console.WriteLine("After filtering");
            foreach( var number in distinctElements )
            {
                Console.WriteLine(number);
            }
        }

    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

    }
}
