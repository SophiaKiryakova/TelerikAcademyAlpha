using System;
using System.Collections.Generic;
using System.Text;

namespace Telerik_OOP_03_Principles_SchoolClasses
{
    public class Student: Person, IComment
    {
        private int classNumber;
        private static List<int> uniqueClassNumber = new List<int>();
        private List<string> comments;

        public Student(string firstName, string lastName, int classNumber): base (firstName, lastName)
        {
            this.ClassNumber = classNumber;
            this.comments = new List<string>();
        }

        public static List<int> UniqueClassNumber
        {
            get
            {
                return uniqueClassNumber;
            }
        }

        public int ClassNumber
        {
            get
            {
                return this.classNumber;
            }
            private set
            {
                if (UniqueClassNumber.Contains(classNumber))
                {
                    throw new ArgumentException("Class number should be unique! This one is already taken!");
                }
                else if(value < 1)
                {
                    throw new ArgumentException("Class number should be more or equal to 1.");
                }
                else
                {
                    this.classNumber = value;
                    UniqueClassNumber.Add(classNumber);
                }
            }
        }
        public string Comments
        {
            get
            {
                return string.Join(", ", this.comments);
            }
        }
        public void AddComment(string comment)
        {
            this.comments.Add(comment);
        }
        public override string Print()
        {
            var sb = new StringBuilder();
            sb.Append(base.Print());
            sb.Append(" Number: " + this.ClassNumber);
            return sb.ToString();
        }
    }
}
