namespace Generics
{
    public class GenericMethod
    {

        //This method sorts the elements in a range of in an Array
        //using the IComparable<T> generic interface implementation of each element of the Array

        //generic method
        public static void SortArray<T>(T[] array) where T : IComparable<T>
        {
            Array.Sort(array);
        }

        public void SortingArrayMethod()
        {
            int[] intArray = {10, 5, 2, 8, 1, 9 };
            double[] doubleArray = { 10.5,3.5, 1.2, 4.0, 2.8 };
            string[] stringArray = {"Mango" ,"banana", "apple", "cherry","orange" };

            SortArray(intArray);
            SortArray(doubleArray);
            SortArray(stringArray);

            Console.WriteLine("Sorted intArray: " + string.Join(", ", intArray));
            Console.WriteLine("Sorted doubleArray: " + string.Join(", ", doubleArray));
            Console.WriteLine("Sorted stringArray: " + string.Join(", ", stringArray));
        }



        //swaping the elements

        // when you pass variables to this method,
        // any changes made to a or b within the method will affect the original variables outside of the method

        //generic method
        public void Swap<T>(ref T a, ref T b)
        {
            Console.WriteLine("Before Swapping parameters are : " + a + ", " + b);
            T temp = a;
            a = b;
            b = temp;
            Console.WriteLine("Before Swapping parameters are:" + a + ", " + b);
        }

        public void SwapingMethod()
        {
            int x = 5, y = 10;
            Swap(ref x, ref y);

            string str1 = "Hello";
            string str2 = "World";
            Swap(ref str1, ref str2);

            double num1 = 20.5;
            double num2 = 78.9;
            Swap(ref num1, ref num2);
        }
    }

    class Employee<T>
    {
        public void DisplayData(T data)
        {
            Console.WriteLine("The data passed is: " + data);
        }
    }

}
