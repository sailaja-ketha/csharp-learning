
namespace Oops
{
    public class ClassMembers
    {
        public class Bottle
        {
            // Fields and methods inside classes are often referred to as Class Members

            //class properties 
            public string Material { get; set; }
            public double CapacityInLiters { get; set; }
            public string Color { get; set; }
            public bool IsReusable { get; set; }
            public string CapType { get; set; }

            public Bottle(string material, double capacity, string color, bool isReusable, string capType)
            {
                Material = material;
                CapacityInLiters = capacity;
                Color = color;
                IsReusable = isReusable;
                CapType = capType;
            }

            // class members
            public void Describe()
            {
                Console.WriteLine("Bottle Details:");
                Console.WriteLine($"Material: {Material}");
                Console.WriteLine($"Capacity: {CapacityInLiters} liters");
                Console.WriteLine($"Color: {Color}");
                Console.WriteLine($"Reusable: {IsReusable}");
                Console.WriteLine($"Cap Type: {CapType}");
            }
        }
    
    }
}
