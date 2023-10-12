
namespace Enums
{
    public  class Enums
    {
        enum Fruits
        {
            Mango,
            Grapes,
            Apple,
            Orange,
            Banana
        }

        enum Days
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
        }
        public static void DisplayFruitsData()
        {
            Console.WriteLine(Fruits.Mango);
            Console.WriteLine(Fruits.Grapes);
            Console.WriteLine(Fruits.Apple);
            Console.WriteLine(Fruits.Orange);
            Console.WriteLine(Fruits.Banana);
            Console.WriteLine((int)(Fruits.Mango));
        }

        public void DisplayDays()
        {
            Console.WriteLine(Days.Monday);
            Console.WriteLine(Days.Tuesday);
            Console.WriteLine(Days.Wednesday);
            Console.WriteLine(Days.Thursday);
            Days currentDay = Days.Thursday;
            if(currentDay == Days.Thursday)
            {
                Console.WriteLine("Current day is : " + currentDay);

            }

        }
    }
}
