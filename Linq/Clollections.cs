
namespace Linq
{
    public class Collections
    {
        public static void Where()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var evenNumbers = numbers.Where(n => n % 2 == 0);
            foreach (var n in evenNumbers)
            {
                Console.WriteLine(n);
            }

        }

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

        public static void Aggreration()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var sum = numbers.Sum();
            Console.WriteLine(sum);
            var average = numbers.Average();
            Console.WriteLine(average);
            var count = numbers.Count();
            Console.WriteLine(count);

        }


        public static void Concat()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var otherNumbers = new List<int> { 5, 6, 7, 8, 9, 10, 11, 12 };
            var combinedNumbers = numbers.Concat(otherNumbers);
            foreach( var number in combinedNumbers )
            {
                Console.WriteLine(number);
            }
        }

    }
}
