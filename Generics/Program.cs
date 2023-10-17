//generic means not specific to a particular data type
//Generics in C# is a feature that allows for the creation of reusable code by creating parameterized types
namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Generics in c sharp");

            // Declare a list of type int.
            GenericList<int> list1 = new GenericList<int>();
            list1.Add(100);
            list1.Add(700);

            // Declare a list of type string.
            GenericList<string> list2 = new GenericList<string>();
            list2.Add("Csharp");

            // Declare a list of type char.
            GenericList<char> list3 = new GenericList<char>();
            list3.Add('s');
            
            Student<string> studentName = new Student<string>("Sailaja");
            Student<int> studentId = new Student<int>(120);

            GenericMethod genericMethod = new GenericMethod();
            genericMethod.SortingArrayMethod();
            genericMethod.SwapingMethod();

            Employee<string> employeeName = new Employee<string>();
            employeeName.DisplayData("sailu");
            Employee<int> employeeId = new Employee<int>();
            employeeId.DisplayData(3423);
            Employee<long> phoneNumber = new Employee<long>();
            phoneNumber.DisplayData(9087654322);

        }

    }
}

