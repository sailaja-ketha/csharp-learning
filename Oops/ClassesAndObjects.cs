

namespace Oops
{
    public class ClassesAndObjects
    {
        public class Classes
        {

            //here laptop is an  class laptop 
            //every class has state and behaviour
            //state is nothing but data behaviour is nothing but methods
            public class Laptop
            {
                // Properties

                //these are called class properties
                public string Brand { get; set; }
                public string Model { get; set; }
                public double ScreenSizeInInches { get; set; }
                public string Processor { get; set; }
                public int RamInGb { get; set; }
                public int StorageInGB { get; set; }
                public double PriceInDollars { get; set; }

                // Constructor
                public Laptop(string brand, string model, double screenSize, string processor, int ram, int storage, double price)
                {
                    Brand = brand;
                    Model = model;
                    ScreenSizeInInches = screenSize;
                    Processor = processor;
                    RamInGb = ram;
                    StorageInGB = storage;
                    PriceInDollars = price;
                }

                // Method to display laptop details

                //class methods
                public void DisplayDetails()
                {
                    Console.WriteLine($"Brand: {Brand}");
                    Console.WriteLine($"Model: {Model}");
                    Console.WriteLine($"Screen Size: {ScreenSizeInInches} inches");
                    Console.WriteLine($"Processor: {Processor}");
                    Console.WriteLine($"RAM: {RamInGb} GB");
                    Console.WriteLine($"Storage: {StorageInGB} GB");
                    Console.WriteLine($"Price: ${PriceInDollars}");
                }
            }
        }

        public class Objects
        {
            public static void WorkingWithObjects()
            {
                //creating object of laptop class
                //objects are real entities using object we can access class members
                Classes.Laptop laptop1 = new Classes.Laptop("HP", "Pavilion", 15.6, "Intel Core i5", 8, 512, 9799.99);
                Classes.Laptop laptop2 = new Classes.Laptop("Dell", "XPS 13", 13.3, "Intel Core i7", 16, 512, 1299.99);
                laptop1.DisplayDetails();
                laptop2.DisplayDetails();
            }
        }
    }
}
