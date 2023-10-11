// operator is a symbol that tell compiler to perform some  mathematical or logical manipulations

class Operators
{
    public void AirthematicOperators()
    {
        Console.WriteLine("Enter the  first number");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the second number");
        int num2 = Convert.ToInt32(Console.ReadLine());

        //Airthematic operators//
        int addition = num1 + num2;
        int subtraction = num1 - num2;
        int multiplication = num1 * num2;
        int division = num1 / num2;
        int remainder=num1 % num2; // modulus
        Console.WriteLine("Sum of the numbers is : " + addition);
        Console.WriteLine("Subtraction Of the Numbers is :" + subtraction);
        Console.WriteLine("Multiplication Of the Numbers is :" + multiplication);
        Console.WriteLine("division Of the Numbers is :" + division);
        Console.WriteLine("Remainder Of the Numbers is :" + remainder);
        Console.WriteLine("PostIncrement operator : "+ num1++);
        Console.WriteLine("PreIncrement operator : " + ++num1);
        Console.WriteLine("Postdecrement operator : " + num1--);
        Console.WriteLine("Predecrement operator : " + --num1);
    }

    public void RelationalOperators()
    {
        Console.WriteLine("Enter the  first number");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the second number");
        int num2 = Convert.ToInt32(Console.ReadLine());
        //Relational operators
        if (num1 == num2)
        {
            Console.WriteLine("The numbers are equal");
        }
        else if(num1!=num2)
        {
            Console.WriteLine("The numbers are not equal");
        }
        else if (num1 < num2)
        {
            Console.WriteLine(num1 + " is lessthan " + num2);

        }
        else if (num1 > num2)
        {
            Console.WriteLine(num1 + " is greaterthan " + num2);
        }
        else if (num1 >= num2)
        {
            Console.WriteLine(num1 + " is greaterthan or equal to " + num2);
        }
        else if (num1 <= num2)
        {
            Console.WriteLine(num1 + " is lessthan or equal to " + num2);
        }
        else
        {
            Console.WriteLine("Else statement if any of the above conditions will not satisfy this will execute");
        }
    }


    public void LogicalOperators()
    {
        Console.WriteLine("Enter the  first number");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the second number");
        int num2 = Convert.ToInt32(Console.ReadLine());
        
        
        if(num1> num2 && num1<num2) 
        {
            Console.WriteLine("Both conditions are true then only execute");
        }
        else if (num1>=num2 || num1<=num2)
        {
            Console.WriteLine("If any one condition is true it will execute");
        }
        else if (num1!=num2)
        {
            Console.WriteLine("If condition is true it will return false viceversa ");
        }
        else
        {
            Console.WriteLine("else statement");
        }

    }


    public void BitwiseOperator()
    {
        int num1 = 20, num2 = 10, result;
        result = num1 & num2;
        Console.WriteLine("Bitwise And if both bits same return 1 or 0 "+ result);

        result = num1 | num2;
        Console.WriteLine("Bitwise or  if any bit value is 1 returns 1 or 0" + result);

        result = num1 ^ num2;
        Console.WriteLine("Bitwise Xor if both bit values are same returns 1 or 0" + result);

        result = num1 << 2;
        Console.WriteLine("Bitwise left shift shifts its left-hand operand left by the number of bits defined by its right-hand operand " + result);

        result = num1 >> 1;
        Console.WriteLine("Bitwise right shift shifts its left-hand operand right by the number of bits defined by its right-hand operand" + result);  
        

    }

    public void ShortHandOperator()
    {
        int age = 21;
        //ternary operator this is short hand if else statement
        string status = age > 18 ? "Eligible for vote" : "Not eligible for vote";
        Console.WriteLine(status);

        // += 
        // *=

        // unary operator
        // -- 
        // ++

    }

    static void Main(string[] args)
    {
        Operators operators= new Operators();
        operators.AirthematicOperators();
        operators.RelationalOperators();
        operators.LogicalOperators();
        operators.BitwiseOperator();
        operators.ShortHandOperator();
    }
}
