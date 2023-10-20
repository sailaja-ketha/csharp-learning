
using System.Runtime.InteropServices;

namespace Linq
{

    //Linq language integrated query
    //using linq we can write queries
    //LINQ is a structured query syntax built in C# and VB.NET to retrieve data from
    //different types of data sources such as collections, ADO.Net DataSet, XML Docs,
    //web service and MS SQL Server and other databases
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Linq***");
            Collections.Where();
            Collections.OrderByMethods();
            Collections.Aggreration();
            Collections.Concat();

        }
    }

}
