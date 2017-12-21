using System.Text;

namespace Telerik_OOP_03_Principles_SchoolClasses
{
    public class Person
    {
        private string firstName;
        private string lastName;

        public Person(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public virtual string Print()
        {
            var sb = new StringBuilder();
            sb.Append(this.FirstName + " " + this.LastName);
            return sb.ToString();
        }
    }
}
