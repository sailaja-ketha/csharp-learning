
namespace ExtensionMethods
{
    public static class ExtensionMethod
    {
        //An extension method is actually a special kind of static method defined in a static class
        //we need to define a static class with static methods.
        //These methods should be marked as 'this' on the first parameter,indicating the type they are extending.
        //The first parameter represents the object on which the method is called
        public static void LargestOfTwoNumbers(this int a, int b)
        {
            if (a < b)
            {
                Console.WriteLine("largest number is:" + b);
            }
            else
            {
                Console.WriteLine("largest number is:" + a);
            }
        }
        public static void AddTwoStrings(this string string1, string string2)
        {
            Console.WriteLine("After Joining strings : " + string1 + string2);
        }

        public static void SumOfNumbers(this int num1,int num2)
        {
            Console.WriteLine("Sum is : " + num1 + num2);
        }

        public static void Product(this double value1, double value2)
        {
            Console.WriteLine("Product is : " + value1 * value2);
        }

        public static void Factorial(this int num)
        {
            int factorial = 1;
            for (int i = 1; i <= num; i++)
            {
                factorial = factorial * i;
            }
            Console.WriteLine("Factorial is : " + factorial);
        }

        public static void SumOfDigits(this int number)
        {
            int sum = 0, b;
            while (number > 0)
            {
                b = number % 10;
                sum = sum + b;
                number = number / 10;
            }
            Console.WriteLine("Sum is : " + sum);
        }

        public static void ProductOfDigits(this int number)
        {
            int product = 1, b;
            while (number > 0)
            {
                b = number % 10;
                product = product * b;
                number = number / 10;
            }
            Console.WriteLine("Product is : " + product);
        }

        public static void FindPostiveOrNot(this int number)
        {
            if(number>0)
            {
                Console.WriteLine("It is a positive number");
            }
            else
            {
                Console.WriteLine("It is Not a positive number");
            }
        }

        public static string GetUpperCase(this string name)
        {
            return name.ToUpper();
        }

        public static void CheckEvenOrNot(this int number)
        {
            string result = (number % 2 == 0) ? "Even" : "odd";
            Console.WriteLine(result);
        }

    }
}
