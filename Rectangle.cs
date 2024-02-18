using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace demo
{
    class Rectangle : Shape
    {
        public double Length { get; set; }
        public double Height { get; set; }
        public Rectangle(double lenght, double height)
        {
            Length = lenght;
            Height = height;
            Name = "Rectangle";
        }

        public override double Area()
        {
            return Length * Height;
        }
        public override void GetInfo()
        {
            base.GetInfo();
            System.Console.WriteLine($"This is a {Length} length");
        }
    }
}