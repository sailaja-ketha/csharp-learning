using System.Runtime.InteropServices;
namespace Linq
{

    //Linq language integrated query
    //using linq we can write queries
    //LINQ is a structured query syntax built in C# to retrieve data from
    //different types of data sources such as collections, ADO.Net DataSet, XML Docs,
    //web service and MS SQL Server and other databases

    //five types of linqs
    //1.linq to objects , 2.linq to xml 3,linq to dataset,4.linq to sql,5.linq to entities
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Linq***");
            LinqMethods.Where();
            LinqMethods.Select();
            LinqMethods.OrderByMethods();
            LinqMethods.Aggreration();
            LinqMethods.Concat();
            LinqMethods.SingleOrDefault();
            LinqMethods.Single();
            LinqMethods.First();
            LinqMethods.FirstOrDefault();
            LinqMethods.GroupBy();
            Console.WriteLine("Linq with Queries");
            QuerySyntax.LinqWithQuery();
            Console.WriteLine("\n");
            Console.WriteLine("Order by");
            QuerySyntax.OrderBy();
            QuerySyntax.GroupBy();
        }
    }

}
