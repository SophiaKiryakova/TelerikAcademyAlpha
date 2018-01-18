using System.Text;

namespace Telerik_OOP_03_Principles_Part_02_Shapes
{
    public class Square: Shape
    {
        public Square(double side) : base(side, side)
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
            sb.Append("Square's surface is");

            return sb.ToString();
        }
    }
}
