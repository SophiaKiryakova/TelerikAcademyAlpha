using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telerik_OOP_05_LambdaLINQExtensionMethods
{
    class StartUp
    {
        static void Main(string[] args)
        {
            // Problem 3. First before last
            var students = new List<Student>
            {
                new Student
                {
                    FirstName = "Gosho",
                    LastName = "Ivanov",
                    Age = 21
                },
                new Student
                {
                    FirstName = "Ivan",
                    LastName = "Peshev",
                    Age = 30
                },
                new Student
                {
                    FirstName = "Pesho",
                    LastName = "Goshev",
                    Age = 23
                }
            };
            var orderedByName = from s in students
                                where s.FirstName.CompareTo(s.LastName) < 0
                                select s;
            PrintCollection(orderedByName);

            // Problem 4.Age range
            var orderedByAge = students.Where(x => x.Age >= 18 && x.Age <= 24); // Order by age between 18 and 24
            PrintCollection(orderedByAge);

            // Problem 5. Order students
            var orderedByNames = students.OrderByDescending(x => x.FirstName).ThenByDescending(x => x.LastName);
            PrintCollection(orderedByNames);


        }
        private static void PrintCollection(IEnumerable collection)
        {
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
