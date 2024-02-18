using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace demo
{
    abstract class Shape
    {
        public String Name { get; set; } = null!;
        public virtual void GetInfo()
        {
            System.Console.WriteLine($"this is {Name}");
        }
        public abstract double Area();

        public override string ToString()
        {
            return $"{Name} is a good toString";
        }
    }
}