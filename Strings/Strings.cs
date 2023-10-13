
namespace Strings
{
    public class Strings
    {
        //creating string 

        public  static void CreatingString()
        {
            string userName = "Sailaja";
            Console.WriteLine(userName);

            string message = "Csharp Learning";
            Console.WriteLine(message);  
        }

        //string provides various methods to perform different operations on strings.
        //some  methods are as follows

        //get lengt of the string 
        public void LengthOfString()
        {
            string message = "Get length of the String";
            Console.WriteLine("The length of the string is : " + message.Length);
        }

        //Joining two strings by using concat function

        public void JoinStrings()
        {
            string string1 = "Hello";
            string string2 = "Technovert";
            string joinedString = string.Concat(string1, string2);
            Console.WriteLine("The concated string is : " + joinedString);
        }


        //compare two strings by using equals method
        public void CompareStrings(string string1, string string2)
        {
            bool result= string1.Equals(string2);
            Console.WriteLine(result);

        }

        public void StringInterpolation()
        {
            string string1 = "Fruit Name is";
            string interpolation = $"{string1} Apple";
            Console.WriteLine(interpolation);
        }

        public void CommonStringMethods()
        {

            //The Split method is used to split a string into an array of substrings based on a specified
            string string1 = "Fruit Name is Banana";
            string[] message = string1.Split(',');
            Console.WriteLine(message[0]);

            //replace method will replace the string with another string
            string text = "Helloo Everyone!";
            string replacedText = text.Replace("Everyone", "Technovert");
            Console.WriteLine(replacedText);

            //get index of the string
            string string2 = "C# programming ";
            int index = string2.IndexOf("C#"); 
            int secondIndex = string2.IndexOf("programming"); 
            Console.WriteLine(index);
            Console.WriteLine(secondIndex);

            //get substring 
            string originalString = "Hello, World!";
            string substring = originalString.Substring(7);
            string subsubstring = originalString.Substring(0, 5);
            Console.WriteLine(substring);
            Console.WriteLine(subsubstring);

            //uppercase and lowercase
            string name = "sailaja ";
            string getUpperCase=name.ToUpper();
            Console.WriteLine(getUpperCase);
            string getLowerCase=name.ToLower();
            Console.WriteLine(getLowerCase);

        }


        //string escape sequences 
        public void EscapeSequences()
        {
            string name = "Hii \"Sailaja\"";
            string getSingleQuote = "\'Sailu\'";
            string getBackSlash = "\\sailaja\\";
            string getNull = "\0sailaja\0";
            string getNewLine = "\nsailu\n";
            string getNewTab = "\t sailaja\t";
            Console.WriteLine("Double quotes" + name);
            Console.WriteLine("Single quotes" + getSingleQuote);
            Console.WriteLine("get null" + getNull);
            Console.WriteLine("new line" + getNewLine);
            Console.WriteLine("backslash" + getBackSlash);
            Console.WriteLine("newtab" + getNewTab);
        }


    }
}
