using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telerik_OOP_05_LambdaLINQExtensionMethods
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public override string ToString()
        {
            return "Firstname: " + this.FirstName + " Lastname: " + this.LastName + " Age: " + this.Age;
        }
    }
}
