namespace Generics
{

    //generic classes
    public class GenericList<T>
    {
        public void Add(T input) 
        { 
            Console.WriteLine("Input is :"+ input);
        }    
    }

    public class Student<T>
    {
      //generic feild
        public T data;
        public Student(T data)
        {
            this.data = data;
            Console.WriteLine("Data: " + this.data);
        }
    }

}
