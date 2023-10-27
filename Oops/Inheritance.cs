
namespace Oops
{
    public class SingleInheritance
    {
        public class Bag
        {
            public string BrandName = "WildCraft";
            public string Color = "Black";
            public double Price = 789.999;
            public void DisplayBagDetails()
            {
                Console.WriteLine("BrandName of the bag is : " + BrandName);
                Console.WriteLine("Color of the bag is : " + Color);
                Console.WriteLine("Price of the bag is : " + Price);
            }
        }

        public class Customer : Bag
        {
        }    
    }

    public class HirarchicalInheritance
    {
        public class Book
        {
            public void Read()
            {
                Console.WriteLine("Read the book");
            }
        }

        public class Students:Book
        {
            public void Write()
            {
                Console.WriteLine("Students can write the book");
            }
            public void Read()
            {
                Console.WriteLine("Students can read the book");
            }
        }

        public class Teachers : Book
        {
            public void Read()
            {
                Console.WriteLine("Teachers can read the book");
            }

            public void Write()
            {
                Console.WriteLine("Teachers can write the book");
            }

        }
    }

    public class MultilevelInheritance
    {
        public class Animal
        {
            public void Eat() { Console.WriteLine("Eating..."); }
        }
        public class Dog : Animal
        {
            public void Bark() { Console.WriteLine("Barking..."); }
        }
        public class BabyDog : Dog
        {
            public void Weep() { Console.WriteLine("Weeping..."); }
        }
    }

    public class MultipleInheritance
    {
        public interface ICar
        {
            void Drive();
        }

        public interface IBike
        {
            void Drive();
        }

        public class Vehicle:ICar,IBike
        {
            public void Drive()
            {
                Console.WriteLine("Implement both car and bike interface methods");
            }
        }
    }
}
