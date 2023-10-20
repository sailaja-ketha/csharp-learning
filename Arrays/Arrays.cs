

namespace Arrays
{ 
    public class Arrays
    {
        public void CreatingArray()
        {
            string[] names = { "Sailaja", "divya", "Supriya", "Leela", "Venu", "Bharathi" };
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
            string[] names = { "Sailaja", "divya", "Supriya", "Leela", "Venu", "Bharathi" };
            Array.Reverse(names);
            Console.WriteLine("Reverse an array is : ");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
        
        public void SortingArray()
        {
            string[] names = { "Sailaja", "divya", "Supriya", "Leela", "Venu", "Bharathi" };
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


        //Multidimensional arrays

        // The multidimensional array is also known as rectangular arrays
        //It can be two dimensional or three dimensional.
        //The data is stored in tabular form row ,column which is also known as matrix.

        //All rows have the same size  // Single contiguous memory block 
        //Combined indexes for single element access
        //Better for smaller arrays and multi-row processing 
        //strength is Compactness

        public void MultiDimesionalArray()
        {
           

            int[,] twoDArray = new int[3, 4];

            // Initialize the elements of the array
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 4; col++)
                {
                    twoDArray[row, col] = row * 4 + col + 1;
                }
            }


            //Accessing the elements
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(twoDArray[i, j] + " ");
                }
                Console.WriteLine();
            }


            char[,] alphabets = new char[6, 6];

            // Initialize the elements of the 2D array
            char currentChar = 'A';
            for (int row = 0; row < 6; row++)
            {
                for (int col = 0; col < 6; col++)
                {
                    alphabets[row, col] = currentChar;
                    currentChar++; // Increment the character for the next element
                }
                Console.WriteLine();
            }

            // Access and print the elements of the 2D array
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 4; col++)
                {
                    Console.Write(alphabets[row, col] + " ");
                }
                Console.WriteLine();
            }


            //2-dimensional  array declaration and intialization
            int[,] arr = { { 1, 2, 3 }, { 4, 5, 6 }, { 8, 9, 1 } };

        }

        public void ThreeDimensionalArray()
        {
            int[,,] arr3d1 = new int[2, 2, 2];

            // Initialize the elements of the 3D array
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    for (int k = 0; k < 2; k++)
                    {
                        arr3d1[i, j, k] = i * 4 + j * 2 + k + 1;
                    }
                }
               
            }

            // Print the 3D array
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    for (int k = 0; k < 2; k++)
                    {
                        Console.WriteLine($"arr3d1[{i}, {j}, {k}] = {arr3d1[i, j, k]}");
                    }
                }
                Console.WriteLine();
            }


            //declaring  and initialization 2 rows of 3-dimensional array
            char[,,] arr3d2 = new char[2, 2, 2] { { { 'c', 'h' }, { 'j', 'k' } }, { { 'c', 'h' }, { 'j', 'k' } } };

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    for (int k = 0; k < 2; k++)
                    {
                        Console.WriteLine($"arr3d1[{i}, {j}, {k}] = {arr3d2[i, j, k]}");
                    }
                }
            }

            //access using index
            Console.WriteLine(arr3d2[0, 0, 0]);

        }

        //Jagged arrays
        //jagged array is also known as "array of arrays" because its elements are arrays
        //Each row can have different size
        //Each row is a different// array Access row first, then column
        //Better for large arrays and row by row processing
        //strength is flexibility

        public void JaggedArray()
        { 
            int[][] arr = new int[3][]; // It has two elements (arrays) //which creates an array of two elements, and each element is initialized as null
            arr[0] = new int[] { 11, 21, 56, 78 }; 
            arr[1] = new int[] { 42, 61, 37, 41, 59, 63 };
            arr[2] = new int[] { 42, 61, 37 };

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j] + " ");
                }
               // Console.WriteLine();
            }

        }


        //difference b/w 2d array and 3d array
        //1.2d array is an array of 1d array and data should be stored in tabluar form with row and column
        // 2D array is a structured collection of elements organized into rows and columns,
        // forming a two-dimensional grid or table.
        // It is essentially an array of arrays, with each element being indexed by two coordinates (row and column)

        //3d arrays
        // A 3D array extends the concept to three dimensions, creating a cuboid-like structure
        // .It is an array of 2D arrays, where each element is indexed by three coordinates (row, column, and depth or layer)
        // Common use cases include representing 3D images, 3D graphics models, volumetric data, medical scans



    }
}
