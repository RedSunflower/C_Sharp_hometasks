using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask3
{
    class Square : Shape, IRounded
    {
        public double Side { get; set; }
        public string Theorem { get; set; }
        double IRounded.Radius_of_rounding { get; set; }
        int IRounded.Number_of_corners { get; set; }

        public Square(double side, string name)
        {
            Name = name;
            Side = side;
        }
        public override double Area()
        {
            double Area;
            Area = Side * Side;
            return Area;
        }
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"It has side {Side}");
        }
    }
}
