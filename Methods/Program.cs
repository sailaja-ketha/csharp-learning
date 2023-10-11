//Methods are nothing but block of code which runs when if it is called 
//to reuse code define the code once, and use it many times

class Methods
{
    //static method with parameters
    public static void CalculatingSum(int a, int b)
    {
          int sum=a+b;
          Console.WriteLine("The sum of the numbers is : " + sum);
    }

    //nonstatic method  without parameters and without return type
    public void CalculatingMultiplication()
    {
        int num1 = 10;
        int num2 = 20;
        int result = num1 * num2;
        Console.WriteLine("The remainder of the numbers is : " + result);
    }

    //method with return type

    public string ReturningName(string name)
    { 
        return name;
    }

    static void Main(String[] args)
    {
        CalculatingSum(10,20);
        Methods methods = new Methods();
        methods.CalculatingMultiplication();
        string name= methods.ReturningName("Sailaja");
        Console.WriteLine(name);
    }
}
