using System;
using System.Collections.Generic;

namespace Telerik_OOP_02_Classes
{
    public class Path
    {
        // Constructor
        public Path()
        {
            this.Points = new List<Point3D>();
        }
        // Property
        public List<Point3D> Points { get; set; }

        // Method for adding points
        public void Add(Point3D point)
        {
            this.Points.Add(point);
        }
        // Method for removing points
        public void Remove(Point3D point)
        {
            this.Points.Remove(point);
        }

        public override string ToString()
        {
            return String.Join("\n", this.Points);
        }
    }
}
