//variables are nothing but store the data of different data types
// there are two types of variables local variable and global variable
// local variable are generally declared  with the function
//global variable can be accessed with in the class and they should be declared in side the class


//int number = 100;

class Variables
{
    //global variables
    //Instance variables
    private int _employeeId = 40;
    private string _studentName = "sailaja";
    private double _height = 5.2;
    char first_letter_of_name = 'S';
    private bool _status = true;

    //Local variables
    public void GetEmployeeId( int employeeId)
    {
        int id;
        id= employeeId;
        Console.WriteLine("This is the Local variable " + id);
    }

    static void Main(string[] args)
    {
        Variables variables = new Variables();
        variables.GetEmployeeId( 40);
        Console.WriteLine("Variables: of different data types");
        Console.WriteLine(variables._employeeId + "\t" + variables._studentName + "\t" + variables. _height + "\t"+ variables.first_letter_of_name + "\t" + variables._status) ;
        //Console.WriteLine(number);//
    }

}