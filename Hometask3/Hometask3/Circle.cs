using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask3
{
    class Circle : Shape, IStretchable
    {
        public double Radius { get; set; }
        int IStretchable.Focal_point1 { get; set; }
        int IStretchable.Focal_point2 { get; set; }
        public string Theorem { get; set; }

        public Circle(double radius, string name)
        {
            Name = name;
            Radius = radius;
        }
        public override double Area()
        {
            double Area;
            Area = Math.PI * (Radius * Radius);
            return Area;
        }
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"It has Radius {Radius}");
        }
    }
}
