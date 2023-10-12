//Exception is a problem that raises during execution of the program
using System;
namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("*****Exception Handling****");
            Exceptions exception = new Exceptions(); 
            exception.IndexOutOfRangeException(); 
            exception.FoormatException();
            exception.DivideByZeroException();
            exception.UserInputException();
            exception.NullReferenceException();



        }
    }
}
