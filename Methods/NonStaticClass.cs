

namespace Methods
{
    //non static class can contain nonstatic methods and static methods and feilds 
    public class NonStaticClass
    {
        //static method with parameters
        public static void AreaOfCircle (double radius)
        {
            double area= 3.14*radius*radius;
            Console.WriteLine("Area of the circle is : " + area);
        }

        //nonstatic method  without parameters and without return type
        public void GetProduct()
        {
            int num1 = 10;
            int num2 = 20;
            int product = num1 * num2;
            Console.WriteLine("The product of the numbers is : " + product);
        }


        public void CalculateSpeed(double distance,double time)
        {
            double speed=distance/time;
            Console.WriteLine("Speed of the car is : " + speed);
        }


        //method with return type
        public int FindMaxNumber(int num1, int num2)
        {
            int maxNum;

            if (num1 > num2)
            { 
                maxNum = num1;
            }
            else 
            { 
                maxNum = num2;
            }    
            return maxNum;
        }
        
    }
}
