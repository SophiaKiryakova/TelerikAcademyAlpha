using System;
using System.Text;

namespace Telerik_OOP_03_Principles__StudentsAndWorkers
{
    class Student : Human
    {
        private double grade;
        public Student(string firstName, string lastName, double grade) : base(firstName, lastName)
        {
            this.Grade = grade;
            if (grade < 2 && grade > 6)
            {
                throw new ArgumentException("Grade should be between 2 and 6 according to the BG standard!");
            }
        }
        public double Grade
        {
            get
            {
                return this.grade;
            }
            set
            {
                if (value < 2 || value > 6)
                {
                    throw new ArgumentException("Grade should be between 2 and 6 according to the BG standard!");
                }
                else
                {
                    this.grade = value;
                }
            }
        }
        public override string Print()
        {
            var sb = new StringBuilder();
            sb.Append(base.Print());
            sb.Append($"Grade: {this.Grade}");
            return sb.ToString();
        }
    }
}
