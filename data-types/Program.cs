//Datatype specifies type and size of variable
//we must declare the type of variable that indicates which type of data is storing

class DataTypes
{
    //for public feilds we use pascalcase
    public int StudentId = 1;
    public byte ByteNumber = 255;
    public sbyte SbyteNumber = 30;
    public short ShortNumber = 100;
    public ushort UshortNumber = 908;
    public long PhoneNumber = 9087654321l;
    public ulong DoorNo = 87654333222ul;
    public double Weight = 40.58d;
    public float Height = 2.39f;
    public char LastLetterOfName = 'u';
    public bool Status = true;
    //for private feilds we use camelcase
    private string name = "Sailu";

    //if we doesnot create any accessspecifier by default it should be private
    string animalName = "Monkey";

    public void PrintStudentDetails()
    {
        Console.WriteLine("Name of the student is : " + name);
        Console.WriteLine("Id of the student is : " + StudentId);
        Console.WriteLine("Phonenumber of the student is : " + PhoneNumber);
        Console.WriteLine("last letter of the student is : " + LastLetterOfName);
        Console.WriteLine("Educational status  is  : " + Status);
        Console.WriteLine("Weight is : " + Weight);
        Console.WriteLine("Height is : " + Height);
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
            Console.WriteLine("Enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your age is: " + age);
        }
    }


}
