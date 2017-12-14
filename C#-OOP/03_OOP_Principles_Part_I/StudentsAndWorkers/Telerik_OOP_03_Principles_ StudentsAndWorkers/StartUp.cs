using System;
using System.Collections.Generic;
using System.Linq;

namespace Telerik_OOP_03_Principles__StudentsAndWorkers
{
    class StartUp
    {
        static void Main(string[] args)
        {
            // We initialize a list of 10 students and sort them by grade in ascending order.
            var listStudents = new List<Student> { new Student("Pesho", "Peshev", 6.00), new Student("Gosho", "Goshev", 5.83),
                new Student("Ivan", "Ivanov", 5.96),  new Student("Peter", "Petrov", 4.83), new Student("Maria", "Marinova", 5.98),
                new Student("Anastasia", "Ivanova", 6.00), new Student("Magdalena", "Nikolova", 3.83), new Student("Nikolai", "Georgiev", 4.83),
                new Student("Alexander", "Dimitrov", 5.23), new Student("Ognyan", "Vasilev", 4.83)};

            Console.WriteLine("Students:");
            foreach(Student student in listStudents.OrderBy(x => x.Grade))
            {
                Console.WriteLine(student.Print());
            }
            Console.WriteLine("\nWorkers:");
            //Initialize a list of 10 workers and sort them by money per hour in descending order.
            var listWorkers = new List<Worker> { new Worker("Peshko", "Peshev", 100, 20), new Worker("Goshko", "Goshev", 50, 50),
                new Worker("Ivancho", "Ivanov", 30, 40),  new Worker("Peter", "Petrov", 500, 40 ), new Worker("Mimi", "Marinova", 70, 40),
                new Worker("Ana", "Ivanova", 300, 25), new Worker("Magi", "Nikolova", 1000, 40), new Worker("Niki", "Georgiev", 60, 10),
                new Worker("Alex", "Dimitrov", 90, 10), new Worker("Ogi", "Vasilev", 60, 10)};

            foreach(Worker worker in listWorkers.OrderByDescending(x => x.CalculateMoneyPerHour()))
            {
                Console.WriteLine(worker.Print());
            }
            //Merge the lists and sort them by first name and last name.
            var mergedLists = new List<Human>();
            mergedLists.AddRange(listStudents);
            mergedLists.AddRange(listWorkers);
            Console.WriteLine("\nSorted merged list by first and then second names:");
            foreach(Human human in mergedLists.OrderBy(x => x.FirstName).ThenBy(x => x.LastName))
            {
                Console.WriteLine(human.Print());
            }
        }
    }
}
