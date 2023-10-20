using System.Reflection;
using static Attributes.CustomAttribute;
namespace Attributes
{
    class Program
    {
        //An attribute is a declarative tag
        //that is used to convey information to runtime
        //about the behaviors of various elements like classes, methods, structures, etc in your program
        //The .Net Framework provides two types of attributes:
        //the pre-defined attributes and custom built attributes
        static void Main(string[] args)
        {
            Console.WriteLine(" ***Attributes***");
            AttributeClass myClass = new AttributeClass();
            MethodInfo oldMethod = typeof(AttributeClass).GetMethod("OldMethod");

            DeprecatedAttribute deprecatedAttribute = oldMethod.GetCustomAttribute<DeprecatedAttribute>();

            if (deprecatedAttribute != null)
            {
                Console.WriteLine("This method is deprecated: " + deprecatedAttribute.Message);
            }
            else
            {
                Console.WriteLine("This method is not deprecated.");
            }


            //custom attribute
            MyLibrary myLibrary = new MyLibrary();
            MethodInfo methodInfo = typeof(MyLibrary).GetMethod("Write");

            AuthorAttribute authorAttribute = methodInfo.GetCustomAttribute<AuthorAttribute>();

            if (authorAttribute != null)
            {
                Console.WriteLine("Author of : " + authorAttribute.AuthorName);
            }
            else
            {
                Console.WriteLine("Author information is not available for this method.");
            }


            //some predefined methods

            Console.WriteLine("Program for Attributes");
            PreDefinedAttributeClass. DemoMethod();


            DeprecatedClass oldInstance = new DeprecatedClass();

            // Calling the deprecated method
            oldInstance.DeprecatedMethod(); // Generates a warning or error

            
            NewClass newInstance = new NewClass();
            newInstance.NewMethod();


            //serialize

            // Create some sample products
            Product product1 = new Product { ProductId = 1, Name = "Laptop", Price = 899.99 };
            Product product2 = new Product { ProductId = 2, Name = "Smartphone", Price = 599.99 };

            // Serialize and save the products to a file
            Serilize.SerializeAndSave(product1, "product1.dat");
            Serilize.SerializeAndSave(product2, "product2.dat");

            // Deserialize and load the products from the file
            Product loadedProduct1 = Serilize. DeserializeAndLoad<Product>("product1.dat");
            Product loadedProduct2 = Serilize.DeserializeAndLoad<Product>("product2.dat");

            // Display the loaded products
            Console.WriteLine("Loaded Product 1: " + loadedProduct1.Name);
            Console.WriteLine("Loaded Product 2: " + loadedProduct2.Name);

            DebugUtility.LogDebugInfo("debug");
            ExternalLibrary.MessageBox();
        }

    }
}
