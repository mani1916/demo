using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace demo
{
    class Circle : Shape
    {
        public double Radius { get; set; }
        public Circle(double radius)
        {
            Radius = radius;
            Name = "Circle";
        }

        public override double Area()
        {
            return (7.28 * (Radius * Radius));
        }
        public override void GetInfo()
        {
            base.GetInfo();
            System.Console.WriteLine($"This is a {Radius} radius");
        }
    }
}