using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask2
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = { new Circle(5,"MyCircle"), new Square(10,"MySquare"),new Square(15,"MySquare1")};
            for (int i = 0; i < shapes.Length; i++)
            {
                shapes[i].GetInfo();

                Console.WriteLine("{0} Area: {1:f2} ", shapes[i].Name, shapes[i].Area());
            }
            Circle circle = new Circle(12, "Round");
            Circle ellipse = new Circle(14, "Ellipse");
            Shape[] ishapes = { circle, ellipse };
            foreach (Shape s in ishapes)
            {
                s.GetInfo();
            }
            Console.ReadLine();
        }
    }
}
