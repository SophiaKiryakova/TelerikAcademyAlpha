namespace Telerik_OOP_03_Principles_AnimalHierarchy
{
    public class Kitten : Cat
    {
        public Kitten(int age, string name) : base (age, name, SexType.Female)
        {
            this.AnimalType = AnimalType.Kitten;
        }
    }
}
