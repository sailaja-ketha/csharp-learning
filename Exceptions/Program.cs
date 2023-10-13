//Exception is a problem that raises during execution of the program
//Exceptions provide a way to transfer control from one part of a program to another
//Exception handling is done by try ,catch , throw,finally keywords

// try-- block identifies a block of code for which particular exceptions is activated 
//catch-- block will handle that exception we have multiple catch blocks based on requirement
//finally-- block is used to execute a given set of statements whether an exception is thrown or not thrown
//throw--A program throws an exception when a problem shows up

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("*****Exception Handling****");
            Exceptions exception = new Exceptions(); 
            exception.IndexOutOfRangeException(); 
            exception.FormatException();
            exception.DivideByZeroException();
            exception.UserInputException();
            exception.NullReferenceException();

        }
    }
}
