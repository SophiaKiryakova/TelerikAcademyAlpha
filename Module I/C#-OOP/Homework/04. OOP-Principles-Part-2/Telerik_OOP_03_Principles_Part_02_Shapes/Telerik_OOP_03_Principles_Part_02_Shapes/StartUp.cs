using System;
using System.Collections.Generic;

namespace Telerik_OOP_03_Principles_Part_02_Shapes
{
    class StartUp
    {
        static void Main(string[] args)
        {
            // We create three figures
            Shape triangle01 = new Triangle(2.4, 5.2);
            Shape square01 = new Square(3.5);
            Shape rectangle01 = new Rectangle(5, 7.8);

            // We create a list that will hold all the different shapes
            IList<Shape> listShapes = new List<Shape>();
            listShapes.Add(triangle01);
            listShapes.Add(square01);
            listShapes.Add(rectangle01);

            foreach(Shape shape in listShapes)
            {
                Console.WriteLine($"{shape.Print()} {shape.CalculateSurface()}");
            }
        }
    }
}
