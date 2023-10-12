//An enum is a special class that represents a group of constants
//Use enums when you have values that you know aren't going to change
namespace Enums
{
    class Program
    {

        static void Main(string[] args)
        {
            Enums.DisplayFruitsData();
            Enums enums=new Enums();
            enums.DisplayDays();
            enums.DisplayVehicles();
        }
    }
}