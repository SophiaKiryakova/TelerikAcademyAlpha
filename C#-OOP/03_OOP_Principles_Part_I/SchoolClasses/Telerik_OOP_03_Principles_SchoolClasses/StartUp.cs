using System;

namespace Telerik_OOP_03_Principles_SchoolClasses
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Student student01 = new Student("Ivelina", "Dyakova", 1);
            Student student02 = new Student("Simon", "Dudt", 24);
            School eleventhGradeA = new School('a', new Teacher("Ms", "Markova"));
            eleventhGradeA.AddStudent(student01);
            eleventhGradeA.AddStudent(student02);
            eleventhGradeA.RemoveStudent(student02);
            eleventhGradeA.AddComment("Commenting and commenting...");
            Console.WriteLine(student01.Comments);
            Console.WriteLine(student01.Print());
            Teacher teacher01 = new Teacher("Mrs", "Bean");
            Console.WriteLine("Teacher: " + teacher01.Print());
        }
    }
}
