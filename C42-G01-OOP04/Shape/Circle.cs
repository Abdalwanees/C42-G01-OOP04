using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G01_OOP04.Shape
{
    internal class Circle : ICircle
    {
        public double Radius { get; set; }
        public double Area
        {
            get
            {
                return Radius * Radius * 3.14;
            }
        }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Circle radius: {Radius}, Area: {Area}");
        }
    }
}
