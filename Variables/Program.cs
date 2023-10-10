//variables are nothing but store the data of different data types
// there are two types of variables local variable and global variable
// local variable can be accessed only with the function
//global variable can be accessed with in class
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
        Variables v = new Variables();
        v.EmployeeId( 40);
        Console.WriteLine("Variables: of different data types");
        Console.WriteLine(v.employeeId + "\t" + v.name + "\t" + v. height + "\t"+ v.firstLetterOfName+"\t" + v.status) ;
    }


}