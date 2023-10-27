using static Oops.ClassMembers;
using static Oops.Abstraction;
using static Oops.Encapsulation;
using static Oops.Polymorphism;
using static Oops.SingleInheritance;
using static Oops.HirarchicalInheritance;
using static Oops.MultilevelInheritance;
using static Oops.MultipleInheritance;
namespace Oops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------Class Members--------");
            Bottle bottle1 = new Bottle("Plastic", 0.5, "Black", true, "Screw Cap");
            Bottle bottle2 = new Bottle("Glass", 0.75, "Pink", false, "Cork");
            bottle1.Describe();
            bottle2.Describe();
            Console.WriteLine("********Classes and Objects******");
            ClassesAndObjects.Objects.WorkingWithObjects();
            Console.WriteLine("%%%%%%%%%%  AccessModifiers %%%%%%%%%%");
            AnotherClass.Operations();
            Console.WriteLine("-------Abstraction--------");
            Circle circle = new Circle(4.5);
            circle.Area();
            Square square = new Square(6);
            square.Area();
            Triangle triangle = new Triangle(2, 3);
            triangle.Area();
            Console.WriteLine("--------Encapsulation---------");
            MonthNameGetter monthGetter = new MonthNameGetter();
            Console.WriteLine("Enter Month number");
            int monthNumber = Convert.ToInt32(Console.ReadLine());
            monthGetter.GetMonthName(monthNumber);
            Console.WriteLine("----------Polymorphism------------");
            StaticPolymorphism staticPolymorphism = new StaticPolymorphism();
            staticPolymorphism.GetRemainder(2.3, 4.5);
            staticPolymorphism.GetRemainder(10, 5);
            staticPolymorphism.GetRemainder(10, 2, 3);
            DynamicPolymorphism dynamicPolymorphism = new DynamicPolymorphism();
            dynamicPolymorphism.BuyMobile();
            Mobile mobile = new Mobile();
            mobile.BuyMobile();
            Console.WriteLine("-------Inheriance-------");
            Console.WriteLine("Single level inheritance : ");
            Customer customer = new Customer();
            customer.DisplayBagDetails();
            Console.WriteLine("Hirarchical inheritance : ");
            Students students = new Students();
            students.Write();
            students.Read();
            Teachers teachers = new Teachers();
            teachers.Write();
            teachers.Read();
            Console.WriteLine("Multi level inheritance : ");
            BabyDog babyDog = new BabyDog();
            babyDog.Bark();
            babyDog.Weep();
            babyDog.Eat();
            Console.WriteLine("Multiple inheritance : ");
            Vehicle vehicle = new Vehicle();
            vehicle.Drive();
        }
    }
}