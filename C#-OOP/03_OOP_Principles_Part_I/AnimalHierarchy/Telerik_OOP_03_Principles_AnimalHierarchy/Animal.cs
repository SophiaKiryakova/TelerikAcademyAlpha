using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Telerik_OOP_03_Principles_AnimalHierarchy
{
    public abstract class Animal : ISound
    {
        private int age;
        private string name;
        private SexType sex;

        public Animal(int age, string name, SexType sex)
        {
            if(age < 0)
            {
                throw new ArgumentException("Age cannot be negative!");
            }
            else
            {
                this.Age = age;
            }
            if(name.Length < 2)
            {
                throw new ArgumentException("Name length cannot be less than two symbols!");
            }
            else
            {
                this.Name = name;
            }
            this.Sex = sex;
            this.AnimalType = AnimalType.Unknown;
        }
        public AnimalType AnimalType { get; set; }
        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                this.age = value;
            }
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        public SexType Sex
        {
            get
            {
                return this.sex;
            }
            set
            {
                this.sex = value;
            }
        }
        public virtual string MakeASound()
        {
            return string.Empty;
        }
        public static double AverageAge(IEnumerable<Animal> animals)
        {
            return animals.Average(x => x.Age);
        }
        public virtual string Print()
        {
            var sb = new StringBuilder();
            sb.Append($"I am a {this.AnimalType.ToString().ToLower()} and I am {this.Age} years old. I like to {this.MakeASound()}.");
            return sb.ToString();
        }
    }
}
