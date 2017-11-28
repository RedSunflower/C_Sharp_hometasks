using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask3
{
    class Square : Shape, IRounded
    {
        public double Side
        {
            set
            {
                _side = value;

            }
            get
            {
                return _side;

            }
        }
        public string Axiom { get; set; }
        double IRounded.Radius_of_rounding { get; set; }
        int IRounded.Number_of_corners { get; set; }
        private double _side;
        public Square(double side, string name)
        {
            Name = name;
            _side = side;
        }
        public Square()
        {
            Name = "SquareItem";
            _side = 1;
        }
        public override double Area()
        {
            double Area;
            Area = _side * _side;
            return Area;
        }
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"It has side {_side}");
        }
    }
}
