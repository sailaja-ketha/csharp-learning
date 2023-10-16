//Arrays are used to store similar type of values in single variable it is fixed size
namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******Arrays******");
            Arrays arrays = new Arrays();
            arrays.CreatingArray();
            Console.WriteLine("----------");
            arrays.SortingArray();
            Console.WriteLine("----------");
            arrays.ArrayMethods();
            Console.WriteLine("----------");
            arrays.ReverseAnArray();
            arrays.FindMethod();
            string[] fruits = { "mango","Grapes","papaya","gova","pinapple" };
            arrays.PassingArrayToFunction(fruits);

            arrays.MultiDimesionalArray();


        }
    }
}