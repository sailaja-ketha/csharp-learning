
namespace Oops
{
    public class Constructor
    {
        //constructors are special methods to initialize feilds and properties
        //constructor name should be same as classname and it cannot have a return type

        int number1;
        int number2;
        public Constructor(int number1, int number2)
        {
            this.number1 = number1;
            this.number2 = number2;
        }

        public void Sum()
        {
            Console.WriteLine("Sum is : " + (number1 + number2)); 
        }
        
    }
}
