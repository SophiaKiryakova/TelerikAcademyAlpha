using StudentGroups;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtentionMethods
{
    public static class ExtensionMethods
    {
        public static void ExtractStudentsWithTwoTwos(this List<Student> students)
        {
            var studentsWithTwoTwos = students
                                    .Where(student => student.Marks.FindAll(x => x == 2).Count == 2)
                                    .ToList();
            foreach (var student in studentsWithTwoTwos)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName + " " + string.Join(", ", student.Marks));
            }
        }
    }
}
