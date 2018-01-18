using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telerik_OOP_02_Classes
{
    static class Distance
    {
        // Static method to calculate the distances between two points
        public static double CalculateDistance(Point3D firstPoint, Point3D secondPoint)
        {
            double result = Math.Pow((secondPoint.X - firstPoint.X), 2) +
                Math.Pow((secondPoint.Y - firstPoint.Y), 2) +
                Math.Pow((secondPoint.Z - firstPoint.Z), 2);

            return result;
        }
    }
}
