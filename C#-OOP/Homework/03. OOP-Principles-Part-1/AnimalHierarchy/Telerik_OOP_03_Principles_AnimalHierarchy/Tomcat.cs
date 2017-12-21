namespace Telerik_OOP_03_Principles_AnimalHierarchy
{
    public class Tomcat: Cat
    {
        public Tomcat(int age, string name): base (age, name, SexType.Male)
        {
            this.AnimalType = AnimalType.Tomcat;
        }
    }
}
