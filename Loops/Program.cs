
//Loops are used to perform some operation again and agian until it reaches the specific condition
//There are 4 types of loops forloop,while,dowhile,nested

class Loops
{
    static void Main(string[] args)
    {
        Loops loops = new Loops();
        loops.ForLoop();
        loops.WhileLoop();
        loops.DoWhileLoop();
        loops.NestedLoop();
        loops.ForEachLoop();
    }

    //for loop will execute if the condition is true and until the condition false it will stops the exceution
    public void ForLoop()
    {
        int number = 5;
        Console.WriteLine("For loop : ");
        for(int i = 0; i < number; i++)
        {
            Console.WriteLine("For loop exercise");
        }
    }

    //the while loop loops through a block of code as long as a specified condition is True
    public void WhileLoop()
    {
        int number = 5;
        Console.WriteLine("While loop : ");
        while (number > 0)
        {
            Console.WriteLine(number);
            number--;
        }
    }

    //this loop will execute the code block once,
    //before checking if the condition is true,
    //then it will repeat the loop as long as the condition is true
    public void DoWhileLoop()
    {
        Console.WriteLine("DoWhile loop : ");
        int number = 90;
        do
        {
            Console.WriteLine(number);
            break;
        }
        while (number > 0);
    }

    //using loop inside another loop is called nested loop
    public void NestedLoop()
    {
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j <= i; j++)
                Console.Write("1");
                Console.WriteLine();        
        }
    }

    //foreach loop loops through the each element in array
    public void ForEachLoop()
    {
        string[] flowerNames = { "Rose", "Jasmin","Lotus" };
        foreach (string i in flowerNames)
        {
            Console.WriteLine(i);
        }
    }
}