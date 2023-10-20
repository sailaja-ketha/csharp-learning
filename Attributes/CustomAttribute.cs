using System.Reflection;
namespace Attributes
{
    public class CustomAttribute
    {
       [AttributeUsage(AttributeTargets.Method, Inherited = false, AllowMultiple = false)]
       public class AuthorAttribute : Attribute
        {
            public string AuthorName { get; set; }

            public AuthorAttribute(string authorName)
            {
                AuthorName = authorName;
            }
        }


       public class MyLibrary
        {
            [Author("Sailaja")]
            public void Write()
            {
                Console.WriteLine("Author can have write");
                
            }
        }
    }
}
