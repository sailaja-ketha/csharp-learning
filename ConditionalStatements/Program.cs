//Conditional statements
// statement that can be executed based on a condition is called condition statement


class ConditionalStatement
{
    static void Main(string[] args)
    {
        IfStatementMethod();
        IfElseStatement();
        ElseIfLadder();
        Switch();
    }
    //simple if statement
    public static void IfStatementMethod()
    {
        Console.WriteLine("Enter the first letter");
        char letter1=Convert.ToChar(Console.ReadLine());
        Console.WriteLine("Enter another letter");
        char letter2=Convert.ToChar(Console.ReadLine());
        if(letter1 == letter2)
        {
            Console.WriteLine("The entered letters are same");
        }
        
    }

    //if else
    public static  void IfElseStatement()
    {
        Console.WriteLine("Enter the first letter");
        char letter1 = Convert.ToChar(Console.ReadLine());
        Console.WriteLine("Enter another letter");
        char letter2 = Convert.ToChar(Console.ReadLine());
        if (letter1 == letter2)
        {
            Console.WriteLine("The entered letters are same");
        }
        else
        {
             Console.WriteLine("The entered letters are not same");
        }

    }

    //if elseif ladder  
    public static void ElseIfLadder()
    {
        int score = 85;
        if (score >= 90)
        {
            Console.WriteLine("A");
        }
        else if (score >= 80)
        {
            Console.WriteLine("B");
        }
        else if (score >= 70)
        {
            Console.WriteLine("C");
        }
        else
        {
            Console.WriteLine("F");
        }
    }

    //switch statement is used to select one of many code blocks to be
    //executed based on the value of a variable or an expression
    public static void Switch()
    {
        int dayOfWeek = 3;
        switch (dayOfWeek)
        {
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("Wednesday");
                break;
            case 4:
                Console.WriteLine("Thursday");
                break;

            case 5:
                Console.WriteLine("Friday");
                break;
            case 6:
                Console.WriteLine("Saturday");
                break;
            default:
                Console.WriteLine("Sunday");
                break;
        }        
    }
}