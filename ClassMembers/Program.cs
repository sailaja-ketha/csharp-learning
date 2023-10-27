namespace ClassMembers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Class Members");
            Bottle bottle1 = new Bottle("Plastic", 0.5, "Black", true, "Screw Cap");
            Bottle bottle2 = new Bottle("Glass", 0.75, "Pink", false, "Cork");
            bottle1.Describe(); 
            bottle2.Describe(); 

        }
    }
}