using System;
using System.Collections.Generic;

namespace Telerik_OOP_03_Principles_SchoolClasses
{
    public class School: IComment
    {
        private static List<char> uniqueClassIdentifier = new List<char>();
        private List<Teacher> setOfTeachers;
        private List<Student> setOfStudents;
        private List<string> comments;
        private char classIdentifier;

        public School(char classIdentifier, Teacher teacher)
        {
            this.NameIdentifier = classIdentifier;
            this.setOfTeachers = new List<Teacher>();
            this.setOfStudents = new List<Student>();
            this.comments = new List<string>();
        }

        public char NameIdentifier
        {
            get
            {
                return this.classIdentifier;
            }

            set
            {
                if (UniqueClassIdentifier.Contains(value))
                {
                    throw new ArgumentException($"Class name must be unique!");
                }
                else
                {
                    this.classIdentifier = value;
                    UniqueClassIdentifier.Add(value);
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

        internal static List<char> UniqueClassIdentifier
        {
            get
            {
                return uniqueClassIdentifier;
            }
        }

        public void AddTeacher(Teacher teacher)
        {
            this.setOfTeachers.Add(teacher);
        }

        public void RemoveTeacher(Teacher teacher)
        {
            this.setOfTeachers.Remove(teacher);
        }

        public void AddStudent(Student student)
        {
            this.setOfStudents.Add(student);
        }

        public void RemoveStudent(Student student)
        {
            this.setOfStudents.Remove(student);
            Student.UniqueClassNumber.Remove(student.ClassNumber);
        }

        public void AddComment(string comment)
        {
            this.comments.Add(comment);
        }
    }
}
