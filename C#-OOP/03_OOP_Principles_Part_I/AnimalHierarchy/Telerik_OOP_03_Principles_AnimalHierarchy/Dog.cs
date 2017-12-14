namespace Telerik_OOP_03_Principles_AnimalHierarchy
{
    namespace Telerik_OOP_03_Principles_AnimalHierarchy
    {
        public class Dog : Animal
        {
            public Dog(int age, string name, SexType sex) : base(age, name, sex)
            {
                this.AnimalType = AnimalType.Dog;
            }
            public override string MakeASound()
            {
                return "Bow - wow";
            }
        }
    }
}
