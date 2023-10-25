using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public class QuerySyntax
    {
        public static void LinqWithQuery()
        {
            int[] scores = new int[] { 97, 92, 81, 60 };
            int[]  scoreQuery = (from score in scores 
                             where score > 80 
                             select score).ToArray();
            foreach (int i in scoreQuery)
            {
                Console.Write(i + " ");
            }
        }  

        public static void OrderBy()
        {
            int[] scores = new int[] { 90, 100, 456, 789, 908 };
            int[] data = (from score in scores
                      orderby score
                      select score).ToArray();

            foreach(int i in data)
            {
                Console.Write(i + " ");
            }
        }

        public static void GroupBy()
        {
                List<Person> people = new List<Person>
                {
                    new Person { Name = "Sailaja", Age = 25 },
                    new Person { Name = "Mounika", Age = 30 },
                    new Person { Name = "Sireesha", Age = 22 },
                    new Person { Name = "Manvitha", Age = 25 },
                };

            List<Person> groupedPeople = (from person in people
                                          where person.Age==30
                                          select person).ToList();


            foreach (Person person in groupedPeople)
            {
                Console.WriteLine(person.Name);
            }

            //var data=from person in people  where people.age==30 select people;

            

            //List<Person> filterData = (from person in people
            //                 group person by person.Age into ageGroup
            //                 where ageGroup.Key == 30
            //                 select ageGroup).ToList();
            

            //Console.WriteLine("\nGrouped People:");
            //foreach (var ageGroup in filterData)
            //{
            //    Console.WriteLine($"Group with Age {ageGroup.Key}:");
            //    foreach (var person in ageGroup)
            //    {
            //        Console.WriteLine($"{person.Name}");
            //    }
            //}

            //group
            List<Person> resultSet =   (from p in  people
                                     where p.Age == 25
                                     select p).ToList();

            foreach (Person person in resultSet)
            {
                Console.WriteLine(person.Name);
            }
                                                   
            ////iterate each group        
            //foreach (var ageGroup in groupedResult)
            //{
            //    Console.WriteLine("Age Group: {0}", ageGroup.Key); //Each group has a key 

            //    foreach (Person s in ageGroup) // Each group has inner collection
            //        Console.WriteLine("Student Name: {0}", s.Name);
            //}

        }
    }

}
