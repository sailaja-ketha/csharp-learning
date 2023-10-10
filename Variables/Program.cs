//variables are nothing but store the data of different data types
// there are two types of variables local variable and global variable
// local variable are generally declared  with the function
//global variable can be accessed with in the class
class Variables
{
    //global variables
    int employeeId = 40;
    string name = "sailaja";
    double height = 5.2;
    char firstLetterOfName = 'S';
    bool status = true;

    //Local variables
    public void EmployeeId( int employeeId)
    {
        int Id;
        Id= employeeId;
        Console.WriteLine("This is the Local variable" + Id);
    }

    static void Main(string[] args)
    {
        Variables variables = new Variables();
        variables.EmployeeId( 40);
        Console.WriteLine("Variables: of different data types");
        Console.WriteLine(variables.employeeId + "\t" + variables.name + "\t" + variables. height + "\t"+ variables.firstLetterOfName+"\t" + variables.status) ;
    }


}