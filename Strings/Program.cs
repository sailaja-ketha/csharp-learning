// string is a collection of characters

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****Strings*****");
            Strings.CreatingString();
            Strings strings = new Strings();
            strings.LengthOfString();
            strings.JoinStrings();
            strings.CompareStrings("Name", "Sailaja");
            strings.EscapeSequences();
            strings.StringInterpolation();
            strings.CommonStringMethods();
            strings.JoinMethod();
        }
    }

}