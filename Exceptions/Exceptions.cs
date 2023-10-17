

namespace Exceptions
{
    public class Exceptions
    {
         string[] colors = { "Red", "Green", "Pink" };


        //Accessing the outof range element we got this exception
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

        //format exception occurs when we converting string to other datatype
        public void FormatException()
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

        //when we are trying to attemp with zero we get this exception
        public void DivideByZeroException()
        {
            
            try
            {
                int a = 10;
                int result = a / 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("DividedByZeroException caught: " + ex.Message);
            }
        }



        //application type exceptions
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


        //null reference exception
        public void StudentList()
        {
            try
            {
                List<string> studentList = null;

                studentList.Add("John");
                Console.WriteLine( studentList);
            }
            catch (Exception ex)
            {
               Console.WriteLine(ex.Message);
            }
        }


        //Null reference exception
        public void NullReferenceException()
        {
            string str = null; ;
            try
            {
                int length = str.Length;
            }
            catch (Exception ex)
            {
                throw;
                throw ex;
                //throw;// will throws the original stack exception
                //throw ex; //will override the stack exception 
                //In Throw ex, the original stack trace information will get override and you will lose the original exception stack trace
                Console.WriteLine("NullReferenceException caught: " + ex.Message);
            }

        }
    }

}
