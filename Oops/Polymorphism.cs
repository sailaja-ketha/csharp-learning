
namespace Oops
{
    //polymorphism means one object has many forms or has one name with multiple functionalities
    //there are 2 types of polymorphism 
    //1.static or compiletime 2.runtime or dynamic

    public class Polymorphism
    {
       //static polymorphism can be done by method overloading  and operator overloading
       //it is also called early binding
        public class StaticPolymorphism
        {

            public void GetRemainder(int a , int b)
            {
                Console.WriteLine("The remainder of the numbers is : " + a%b);
            }

            public void GetRemainder(int a, int b, int c)
            {
                Console.WriteLine("The remainder of the numbers is : " + (a % b%c));
            }

            public void  GetRemainder(double a , double b)
            {
                Console.WriteLine("The remainder of the numbers is : " + a % b);
            }

        }

        //dynamic polymorphism can be done by method overriding it is also called late binding
        public class DynamicPolymorphism 
        {
            public virtual void  BuyMobile()
            {
                Console.WriteLine("Buy mobile from flipcart");
            }

        }
        public class Mobile: DynamicPolymorphism
        {
            public override void BuyMobile()
            {
                Console.WriteLine("Buy mobile from amazon");
            }
        }
        

    }
}
