using System.Text;

namespace Telerik_OOP_02_Classes
{
    public struct Point3D
    {
        // private static read-only field to hold the start of the coordinate system 
        private static readonly Point3D center = new Point3D(0, 0, 0);
        // Constructor
        public Point3D(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
        // Properties
        public double X { get; private set; }
        public double Y { get; private set; }
        public double Z { get; private set; }

        // Static property to return the point O
        public static Point3D Center
        {
            get { return Point3D.center; }
        }
        // Implementing ToString() to enable printing
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append($"Point coordinates:\nX: {this.X}\nY: {this.Y}\nZ: {this.Z}");
            return sb.ToString();
        }
    }
}
