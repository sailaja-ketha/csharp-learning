

namespace Exceptions
{
    public class Exceptions
    {
         string[] colors = { "Red", "Green", "Pink" };

         public void IndexOutOfRangeException()
         {
            try 
            {
                Console.WriteLine(colors[3]);
            }
            catch (Exception ex)
            { 
                Console.WriteLine(ex.Message);
            }
            finally
            {
               Console.WriteLine("Finally block executed.");
            }

        }

        public void FoormatException()
        {

            string input = "abc";
            try
            {
                int number = int.Parse(input);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("FormatException caught: " + ex.Message);
            }

        }

        public void DivideByZeroException()
        {
            int result;
            try
            {
                int a = 10;
                result = a / 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("DividedByZeroException caught: " + ex.Message);
            }
        }


        public void UserInputException()
        {
            try
            {
                Console.WriteLine("Enter Number");
                int number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(number);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public void NullReferenceException()
        {
            string str = null;
            try
            {
                int length = str.Length;
            }
            catch (Exception ex)
            {
                Console.WriteLine("NullReferenceException caught: " + ex.Message);
            }

        }
    }

}
