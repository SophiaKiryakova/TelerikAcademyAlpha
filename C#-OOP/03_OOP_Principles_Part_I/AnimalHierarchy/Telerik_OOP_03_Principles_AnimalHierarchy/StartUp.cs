using System;
using System.Collections.Generic;
using Telerik_OOP_03_Principles_AnimalHierarchy.Telerik_OOP_03_Principles_AnimalHierarchy;

namespace Telerik_OOP_03_Principles_AnimalHierarchy
{
    class StartUp
    {
        static void Main(string[] args)
        {
            // We add different animals
            Cat catFirst = new Cat(2, "Puhcho", SexType.Female);
            Cat catSecond = new Cat(5, "Fluffy", SexType.Male);
            Dog dogFirst = new Dog(3, "Snowball", SexType.Male);
            Dog dogSecond = new Dog(4, "Rex", SexType.Female);
            Frog frog = new Frog(1, "Hoppie", SexType.Male);
            Kitten kitten = new Kitten(3, "Belle");
            Tomcat tomcat = new Tomcat(4, "Tom");

            // We add all the animals in one likittenst
            Console.WriteLine("List of different animals:\n");
            var animals = new List<Animal> { catFirst, catSecond, frog, dogFirst, dogSecond, frog, frog, tomcat };
            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal.Print());
            }
            Console.WriteLine("\nAnimals' average age:");
            Console.WriteLine("{0:F2} years", Animal.AverageAge(animals));

            Console.WriteLine("\nCat array:");
            Cat[] catArray = new Cat[] { catFirst, catSecond, new Cat(4, "Pufinka", SexType.Female)};
            foreach (Cat cat in catArray)
            {
                Console.WriteLine(cat.Print());
            }
            Console.WriteLine("\nAverage years of all cats:\n{0:F2} years", Animal.AverageAge(catArray));
        }
    }
}
