using static Oops.AccessModifiers;
namespace Oops
{
    public class AccessModifiers
    {
        //public means we can access anywhere
        public static  class PublicAccessModifier
        {
            public static string Name = "Sailaja";     
        }

        //access only with in same class
        private static class PrivateAccessModifier
        {
            private static int age = 22;   

        }

        //access only within same class and derived class
        protected class ProtectedAccessModifier
        {
            protected double weight = 37.90;
        }

        //access only with in same assembly
        internal class InternalClass
        {
            internal static int height = 6;

        }
    }

    class AnotherClass
    {
        public static void Operations()
        {
            //we can access the name property because it is public
            PublicAccessModifier.Name = "Sailaja Ketha";
            Console.WriteLine(PublicAccessModifier.Name);
            //We got an error like cannot access because of its protection level
            //we can access this variable in only within same class

            //PrivateAccessModifier.age = 22;

            //We got an error like cannot access because of its protection level
            //we can access this variable with in the same class and derived class only

            //ProtectedAccessModifier.weight = 78.9;

            InternalClass.height = 9;
            Console.WriteLine(InternalClass.height);


        }
    }
}
