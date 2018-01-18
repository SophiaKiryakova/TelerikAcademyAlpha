using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGroups
{
    public class Student
    {
        // Create a class Student with properties FirstName, LastName, FN, Tel, Email, Marks (a List), GroupNumber.

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FacultyNumber { get; set; }
        public string Tel { get; set; }
        public string EMail { get; set; }
        public List<int> Marks { get; set; }
        public int GroupNumber { get; set; }

        public override string ToString()
        {
            return "First name: " + this.FirstName + ", Last name: " + this.LastName;
        }
    }
}
