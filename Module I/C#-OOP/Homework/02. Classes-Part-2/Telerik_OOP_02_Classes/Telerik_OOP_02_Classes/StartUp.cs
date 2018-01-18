using System;
using System.Linq;

namespace Telerik_OOP_02_Classes
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Point3D firstPoint = new Point3D(3, 4, 5);
            Console.WriteLine(firstPoint.ToString());
            Point3D centerPoint = new Point3D(0, 0, 0);
            Console.WriteLine(centerPoint.ToString());

            Console.WriteLine("Distance from the first to the second point is {0}.", Distance.CalculateDistance(firstPoint, centerPoint));

            Path path = new Path();

            path = PathStorage.Load("../../input.txt");
            Console.WriteLine(path.Points.Count());
            // Saves points in file
            PathStorage.Save(path, "../../output.txt");
        }
    }
}
