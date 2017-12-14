using System.Text;

namespace Telerik_OOP_03_Principles__StudentsAndWorkers
{
    public abstract class Human
    {
        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual string Print()
        {
            var sb = new StringBuilder();
            sb.Append($"{this.FirstName} {this.LastName}");
            return sb.ToString();
        }
    }
}
