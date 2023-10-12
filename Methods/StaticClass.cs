
namespace Methods
{
    //static class can contain only static methods and feilds
    public static  class StaticClass
    {
        public static int student_id = 20;
        public static long phone_number = 9087654321;
        public static string name = "sailaja";

        public static void displayDetails()
        {
            Console.WriteLine("Name of the student is : " + name);
            Console.WriteLine("Id of the student is : " + student_id);
            Console.WriteLine("number of the student is : " + phone_number);
        }
    }
}
