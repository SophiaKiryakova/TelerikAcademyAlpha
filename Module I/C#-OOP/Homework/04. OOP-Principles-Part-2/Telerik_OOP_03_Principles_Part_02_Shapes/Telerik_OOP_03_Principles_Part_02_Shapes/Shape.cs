using System;
using System.Text;

namespace Telerik_OOP_03_Principles_Part_02_Shapes
{
    public abstract class Shape
    {
        private double width;
        private double height;

        public Shape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }
        public double Width
        {
            get
            {
                return this.width;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width must be bigger than 0!");
                }
                this.width = value;
            }
        }
        public double Height
        {
            get
            {
                return this.height;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height must be bigger than 0!");
                }
                this.height = value;
            }
        }
        public abstract double CalculateSurface();
        public virtual string Print()
        {
            var sb = new StringBuilder();
            sb.Append($"First side: {this.Width} ");
            sb.Append($"Second side: {this.Height}");

            return sb.ToString();
        }
    }
}
