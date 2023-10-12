
namespace Methods
{
    public class MethodOverLoading
    {
        //method overloading  multiple methods can have same method name with different list of arguments
        public void GetSum(int num1, int num2)
        {
            int sum = num1 + num2;
            Console.WriteLine("Sum of integer values : " + sum);

        }
        public void GetSum(double num1, double num2)
        {
            double sum = num1 + num2;
            Console.WriteLine("Sum of double values : " + sum);
        }
        public void GetSum(int a, int b, int c)
        {
            Console.WriteLine("Sum of integer values : " + (a + b + c));
        }



        public void CalculateArea(double length, double width)
        {
            Console.WriteLine("area of rectangle: " +( length * width));
        }

        public void CalculateArea(double radius)
        {
            Console.WriteLine("area of circle: " + ( Math.PI * Math.Pow(radius, 2)));
        }

        public void CalculateArea(int baseLength, int height)
        {

            Console.WriteLine("area of triangle: " + (0.5 * baseLength * height));
        }
    }
}
