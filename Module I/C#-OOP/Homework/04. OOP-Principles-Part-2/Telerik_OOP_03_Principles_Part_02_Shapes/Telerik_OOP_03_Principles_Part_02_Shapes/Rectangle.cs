using System.Text;

namespace Telerik_OOP_03_Principles_Part_02_Shapes
{
    public class Rectangle: Shape
    {
        public Rectangle(double width, double height) : base(width, height)
        {
        }
        public override double CalculateSurface()
        {
            double surface = this.Height * this.Width;
            return surface;
        }
        public override string Print()
        {
            var sb = new StringBuilder();
            sb.Append("Rectangle's surface is");

            return sb.ToString();
        }
    }
}
