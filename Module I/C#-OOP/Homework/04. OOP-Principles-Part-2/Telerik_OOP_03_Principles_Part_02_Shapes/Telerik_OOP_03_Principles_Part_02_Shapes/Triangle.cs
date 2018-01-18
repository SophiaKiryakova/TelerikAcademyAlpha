using System.Text;

namespace Telerik_OOP_03_Principles_Part_02_Shapes
{
    public class Triangle: Shape
    {
        public Triangle(double width, double heigth) : base(width, heigth)
        {

        }
        public override double CalculateSurface()
        {
            double surface = this.Height * this.Width / 2;
            return surface;
        }
        public override string Print()
        {
            var sb = new StringBuilder();
            sb.Append("Triangle's surface is");

            return sb.ToString();
        }
    }
}
