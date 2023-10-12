
namespace Methods
{
    //static class can contain only static methods and feilds
    public static  class StaticClass
    {
        public static int studentId = 20;
        public static long phoneNumber = 9087654321;
        public static string name = "sailaja";

        public static void DisplayDetails()
        {
            Console.WriteLine("Name of the student is : " + name);
            Console.WriteLine("Id of the student is : " + studentId);
            Console.WriteLine("number of the student is : " + phoneNumber);
        }
    }
}
