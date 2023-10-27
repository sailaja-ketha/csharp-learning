using static ClassesAndObjects.Classes;
namespace ClassesAndObjects
{
    public class Objects
    {
        public static void WorkingWithObjects()
        {
            //creating object of laptop class
            //objects are real entities using object we can access class members
            Laptop laptop1 = new Laptop("HP", "Pavilion", 15.6, "Intel Core i5", 8, 512, 9799.99);
            Laptop laptop2 = new Laptop("Dell", "XPS 13", 13.3, "Intel Core i7", 16, 512, 1299.99);
            laptop1.DisplayDetails();
            laptop2.DisplayDetails();
        }
    }
}
