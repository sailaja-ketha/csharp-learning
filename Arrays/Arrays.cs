
namespace Arrays
{
    
    public class Arrays
    {
        string[] names = { "Sailaja", "divya", "Supriya", "Leela", "Venu", "Bharathi" };
        public void CreatingArray()
        {
            
            Console.WriteLine("Accssessing array elements using loop");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("Using index accessing the element in array " + names[2]);
            Console.WriteLine("Length of the array is : " + names.Length);
            Console.WriteLine("index of the element" + Array.IndexOf(names,"divya"));
        }  


        public void ReverseAnArray()
        {
            Array.Reverse(names);
            Console.WriteLine("Reverse an array is : ");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
        
        public void SortingArray()
        {
            Array.Sort(names);
            Console.WriteLine("Array elements after sorting :");
            for(int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
        }

        public void ArrayMethods()
        {
            int[] studentIds = { 20, 26, 27, 29, 36, 38 };
            Console.WriteLine("Largest num in array is : " + studentIds.Max());  // returns the largest value in the array
            Console.WriteLine("Smallest num in array is : " + studentIds.Min());  // returns the smallest value in the array
            Console.WriteLine("Sum of the all elements in array is : " + studentIds.Sum());  //returns the sum of all the values in the array
        }

        public void FindMethod()
        {
            int[] numbers = { 10, 20, 30, 40, 50 };
            int result = Array.Find(numbers, num => num > 10);//it will return the first element which satisfy the condition
            Console.WriteLine(result);
            int[] result2=Array.FindAll(numbers, x => x > 20);//it will return all the elements which satisfies the condition
            for(int i=0; i<result2.Length; i++)
            { 
                Console.WriteLine(result2[i]);
            }
        }

        //passing array to a function
        public void PassingArrayToFunction(string[] fruits)
        {
            Console.WriteLine("Printing fruits names:");
            for (int i = 0; i < fruits.Length; i++)
            {
                Console.WriteLine(fruits[i]);
            }
        }


        


    }
}
