using System;
using System.Linq;
using System.IO;

namespace Telerik_OOP_02_Classes
{
    public static class PathStorage
    {
        public static Path Load(string filePath)
        {
            Path path = new Path();

            // We read our file and we split it by next line
            string contentFile = File.ReadAllText(filePath);
            var points = contentFile.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

            // We loop through the lines and we take the points
            for(int i = 0; i < points.Length; i++)
            {
                var coordinates = points[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
                path.Add(new Point3D(coordinates[0], coordinates[1], coordinates[2]));
            }
            return path;
        }
        // We save the information in our file
        public static void Save(Path points, string filePath)
        {
            File.WriteAllText(filePath, points.ToString());
        }
    }
}
