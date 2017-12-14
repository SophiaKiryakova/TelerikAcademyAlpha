namespace Telerik_OOP_03_Principles_AnimalHierarchy
{
    public class Cat : Animal
    {
        public Cat(int age, string name, SexType sex): base (age, name, sex)
        {
            this.AnimalType = AnimalType.Cat;
        }
        public override string MakeASound()
        {
            return "Meow";
        }
    }
}


