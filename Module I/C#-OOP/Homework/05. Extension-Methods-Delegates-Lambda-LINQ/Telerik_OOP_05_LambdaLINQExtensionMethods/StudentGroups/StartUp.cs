using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGroups
{
    class StartUp
    {
        static void Main(string[] args)
        {
            // Problem 9. Student groups
            // Create a List<Student> with sample students. Select only the students that are from group number 2.
            // Use LINQ query.Order the students by FirstName.
            var students = new List<Student>
            {
                new Student
                {
                    FirstName = "Josiane",
                    LastName = "Boissard",
                    FacultyNumber = "0123",
                    EMail = "jb@gmail.com",
                    Tel = "06789235324",
                    Marks = new List<int> {3, 4, 6},
                    GroupNumber = 1             
                },
                 new Student
                {
                    FirstName = "Gerard",
                    LastName = "Depardieu",
                    FacultyNumber = "0124",
                    EMail = "gd@gmail.com",
                    Tel = "06789235674",
                    Marks = new List<int> {6, 6, 6},
                    GroupNumber = 2
                },
                  new Student
                {
                    FirstName = "Jean",
                    LastName = "Renau",
                    FacultyNumber = "0125",
                    EMail = "jr@abv.bg",
                    Tel = "06789233474",
                    Marks = new List<int> {6, 6, 5},
                    GroupNumber = 2
                },
                   new Student
                {
                    FirstName = "Marion",
                    LastName = "Cotillard",
                    FacultyNumber = "0125",
                    EMail = "marion@gmail.com",
                    Tel = "02568796",
                    Marks = new List<int> {6, 5, 6},
                    GroupNumber = 1
                }
            };
            Console.WriteLine("Students in group 2:");
            var studentInGroupTwo = students.OrderBy(x => x.FirstName).Where(x => x.GroupNumber == 2);
            foreach (var student in studentInGroupTwo)
            {
                Console.WriteLine(student);
            }

            // Problem 11.Extract students by email
            var studentsWithAbvMail = students.Where(x => x.EMail.Contains("abv.bg"));
            Console.WriteLine("\nStudents with an abv.bg mail:");
            foreach (var student in studentsWithAbvMail)
            {
                Console.WriteLine(student + " with an email: " + student.EMail);
            }

            // Problem 12. Extract students by phone
            var studentsSofiaPhones = students.Where(x => x.Tel.StartsWith("02"));
            Console.WriteLine("\nStudents with a Sofia phone:");
            foreach (var student in studentsSofiaPhones)
            {
                Console.WriteLine(student + " with a phone number: " + student.Tel);
            }

            // Problem 13. Extract students by marks
            var studentsWithAtLeastOneSix = from student in students
                                            where student.Marks.Contains(6)
                                            select new { Names = student.FirstName + " " + student.LastName, Marks = string.Join(", ", student.Marks) };
            Console.WriteLine("\nStudents that have at least one Excellent (6) mark:");
            foreach (var student in studentsWithAtLeastOneSix)
            {
                Console.WriteLine(student);
            }
        }
    }
}
