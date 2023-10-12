//Methods are nothing but block of code which runs when if it is called 
//to reuse code define the code once, and use it many times
namespace Methods
{
    class Program
    {
        static void Main(String[] args)
        {
            NonStaticClass.AreaOfCircle(2.5);//calling static method in nonstatic class
            NonStaticClass nonStaticClass = new NonStaticClass();
            nonStaticClass.GetProduct(); //method without arguments
            nonStaticClass.FindSpeed(2.3, 20);

            StaticClass.displayDetails();
            int result=nonStaticClass.FindMaxNumber(20, 25);//method with return type
            Console.WriteLine("The maximun number is : " + result);

            MethodOverLoading methodOverLoading = new MethodOverLoading();
            methodOverLoading.GetSum(10, 5);//method overloading
            methodOverLoading.GetSum(20.5, 10.5);//method overloading
            methodOverLoading.GetSum(50, 10, 20);//method overloading

            methodOverLoading.CalculateArea(2, 6);
            methodOverLoading.CalculateArea(2.5, 6.7);
            methodOverLoading.CalculateArea(5.5);
            methodOverLoading.CalculateArea(5.5);


        }
    }
}
