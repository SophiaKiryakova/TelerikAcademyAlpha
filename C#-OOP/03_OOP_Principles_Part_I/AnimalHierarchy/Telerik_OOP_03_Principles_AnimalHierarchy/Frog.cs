namespace Telerik_OOP_03_Principles_AnimalHierarchy
{
    public class Frog : Animal
    {
        public Frog(int age, string name, SexType sex) : base(age, name, sex)
        {
            this.AnimalType = AnimalType.Frog;
        }
        public override string MakeASound()
        {
            return "Kwak";
        }
    }
}


