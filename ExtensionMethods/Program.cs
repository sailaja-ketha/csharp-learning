namespace ExtensionMethods
{
    class Program
    {

        // They allows us to add new functionality to existing types without modifying their source code
        //ExtensionMethods are additional methods.
        //Extension methods allow you to inject additional methods without modifying,
        //deriving or recompiling the original class, struct or interface
        static void Main(string[] args)
        {
            Console.WriteLine("***Extension methods***");
            "sailaja".AddTwoStrings("ketha");
            20.SumOfNumbers(30);
            2.5.Product(0.5);
            30.LargestOfTwoNumbers(20);
            3.Factorial();
            21.SumOfDigits();
            23.ProductOfDigits();
            1.FindPostiveOrNot();
            string name = "sailaja".GetUpperCase();
            Console.WriteLine(name);
            9.CheckEvenOrNot();
        }
    }
}
