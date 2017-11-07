using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask2
{
    abstract class Shape
        
    { public string Name { get; set; }
        public virtual void GetInfo()
        {
            Console.WriteLine($"This is {Name}");
        }
        public abstract double Area();
    }
    interface IRounded {
        double Radius_of_rounding { get; set; }
        int Number_of_corners { get; set; }
    }
    interface IStretchable
    {
        int Focal_point1 { get; set; }
        int Focal_point2 { get; set; }
    }
    class Square : Shape ,IRounded
    { public double Side { get; set; }
        double IRounded.Radius_of_rounding { get ; set ; }
        int IRounded.Number_of_corners { get ; set ; }

        public Square(double side, string name) {
            Name = name;
            Side = side;
        }
        public override double Area()
        {
            double Area;
            Area = Side * Side;
            return Area;  
        }
        public override void GetInfo() {
            base.GetInfo();
            Console.WriteLine($"It has side {Side}");
        }
    }

    class Circle : Shape,IStretchable
    {
        public double Radius { get; set; }
        public int Focal_point1 { get ; set ; }
        public int Focal_point2 { get ; set ; }

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
