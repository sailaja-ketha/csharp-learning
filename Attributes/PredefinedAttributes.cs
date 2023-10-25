using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Attributes
{
   
        //Attribute Usage How the custom class can be used
        [AttributeUsage(AttributeTargets.Method, Inherited = false, AllowMultiple = false)]
        class DeprecatedAttribute : Attribute
        {
            public string Message { get; }

            public DeprecatedAttribute(string message)
            {
                Message = message;
            }
        }

        class AttributeClass
        {
            [Deprecated("This method is no longer supported. Use NewMethod instead.")]
            public void OldMethod()
            {
                int a = 10;
                int b = 20;
                Console.WriteLine(a + b);
            }

            public void NewMethod()
            {
                int a = 10;
                int b = 20;
                Console.WriteLine(a * b);

            }
        }


    //Predefined attributes are a set of attributes that are built into the .NET library by Microsoft.
    //There is a base class for attributes called [System.Attribute].
    //Every custom or predefined attribute inherits from this base class
    //The most common predefined attributes are:  Serialization ,NonSerialization ,Obsolete, DllImport ,WebMethod

    public class PreDefinedAttributeClass
    {
        [Obsolete("Don't use the DemoMethod()", false)]
        public static void DemoMethod()
        {
            Console.WriteLine("Inside DemoMethod()");
        }
    }


    public class DeprecatedClass
    {
        [Obsolete("This class is obsolete. Use NewClass instead.")]
        public void DeprecatedMethod()
        {
            Console.WriteLine("This is deprecated");
            
        }
    }

    public class NewClass
    {
        public void NewMethod()
        {
            Console.WriteLine("Adding new method");   
        }
    }


    //it is commonly used to mark classes as serializable,
    //meaning their instances can be converted to a format that can be stored,
    //transmitted over a network, or saved to disk

    [Serializable]
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }


    public class Serilize
    {
        public static void SerializeAndSave<T>(T data, string fileName)
        {
            IFormatter formatter = new BinaryFormatter();
            using (Stream stream = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                formatter.Serialize(stream, data);
            }
        }

       public  static T DeserializeAndLoad<T>(string fileName)
        {
            IFormatter formatter = new BinaryFormatter();
            using (Stream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                return (T)formatter.Deserialize(stream);
            }
        }
    }

    //The [Conditional] attribute is used to specify that a method should be conditionally
    //compiled based on a specified symbol. It's often used for debugging and conditional compilation
    class DebugUtility
    {
        [Conditional("DEBUG")]
        public static void LogDebugInfo(string message)
        {
            // Debugging code
        }

    }

    

    
}
