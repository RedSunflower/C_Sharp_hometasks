using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask3
{
    class Circle : Shape, IStretchable
    {
        public double Radius
        {
            set
            {
                _Radius = value;

            }
            get
            {
                return _Radius;
            }
        }
        int IStretchable.Focal_point1 { get; set; }
        int IStretchable.Focal_point2 { get; set; }
        public string Theorem { get; set; }
        private double _Radius;
        public Circle(double radius, string name)
        {
            Name = name;
            _Radius = radius;
        }
        public Circle()
        {
            Name = "RoundItem";
            _Radius = 1;
        }
        public override double Area()
        {
            double Area;
            Area = Math.PI * (_Radius * _Radius);
            return Area;
        }
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"It has Radius {_Radius}");
        }
    }
}
