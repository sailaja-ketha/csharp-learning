//Datatype specifies type and size of variable
//we must declare the type of variable that indicates which type of data is storing

class DataTypes
{
    int studentId = 1;
    long phoneNumber = 9087654321l;
    double weight = 40.58d;
    float height = 2.39f;
    char lastLetterOfName= 'u';
    bool status = true;
    string name = "Sailu";

    public void PrintStudentDetails()
    {
        Console.WriteLine("Name of the student is : " + name);
        Console.WriteLine("Id of the student is : " + studentId);
        Console.WriteLine("Phonenumber of the student is : " + phoneNumber);
        Console.WriteLine("last letter of the student is : " + lastLetterOfName);
        Console.WriteLine("Educational status  is  : " + status);
        Console.WriteLine("Weight is : " + weight);
        Console.WriteLine("Height is : " + height);
    }

    static void Main(string[] args)
    {
        DataTypes dataTypes = new DataTypes();
        Console.WriteLine("Data Types");
        dataTypes.PrintStudentDetails();

        TypeCasting typeCasting = new TypeCasting();
        Console.WriteLine("Type casting");
        typeCasting.ConvertedDataTypes();
        typeCasting.ExplicitTypeCasting();
    }


    //typecasting//
    //1.Implicit 2.Explicit
    //1.Implicit typecasting is converting automatically  char --> int-->long-->float-->double
    //2.Explicit convert one type to another manually double-->float-->long-->int-->char


    class TypeCasting 
    {
        //Implicit type Casting
        public static int age = 21;
        public static double convertedAge = age;

        public static char letter = 'a';
        public static int convertedLetter = letter;

        public static long phoneNumber = 9087654321l;
        public static float convertedPhoneNumber= phoneNumber;



        public void ConvertedDataTypes()
        {
            Console.WriteLine("Converted age is : " + convertedAge);
            Console.WriteLine("Converted letter is : " + convertedLetter);
            Console.WriteLine("Converted phonenumber is : " + convertedPhoneNumber);
        }

        //Explicit type casting
        public void ExplicitTypeCasting()
        {
            Console.WriteLine( Convert.ToInt32(convertedAge));
            Console.WriteLine(Convert.ToChar(convertedAge));
            Console.WriteLine("Enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your age is: " + age);
        }
    }


}
