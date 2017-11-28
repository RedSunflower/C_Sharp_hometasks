using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter number of elements ");
            string userElementNumber = Console.ReadLine();
            int userArrayLength;
            bool isNumber = int.TryParse(userElementNumber, out userArrayLength);
            if (isNumber)
                Console.WriteLine($"You entered number:  {userArrayLength}");
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You entered not a number!!");
                Console.ForegroundColor = ConsoleColor.White;
            }

            Shape[] shapes = new Shape[userArrayLength];
            if (userArrayLength == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error! Array cannot be of a length 0!");
                Console.ReadKey();
                return;

            }
            bool isFull = true;
            int count = 0;
            while (isFull)
            {
                Console.WriteLine("Enter name of a class : Circle or Square or Display to see created elements ");
                string className = Console.ReadLine();
                
                
                if (className == "Circle")
                {
                    Console.WriteLine(" You are creating an array of elements of Circle Class!!");
                            shapes[count] = new Circle();
                    Console.WriteLine(" Enter radius value : ");
                    string radius = Console.ReadLine();
                    double tempR;
                    bool isRNumber = double.TryParse(radius, out tempR);
                    if (shapes[count] is Circle)
                    {

                        if (isRNumber)
                        {
                            ((Circle)shapes[count]).Radius = tempR;
                            shapes[count].Name = className;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("You entered not a number!!");
                            Console.ForegroundColor = ConsoleColor.White;
                        }

                    }
                    count++;
                          
                }
                else if (className == "Square")
                {
                    Console.WriteLine(" You are creating an array of elements of Square Class!!");
                    shapes[count] = new Square();
                    Console.WriteLine(" Enter side value : ");
                    string side = Console.ReadLine();
                    double tempSide;
                    bool isSNumber = double.TryParse(side, out tempSide);
                    if (shapes[count] is Square)
                    {

                        if (isSNumber)
                        {
                            ((Square)shapes[count]).Side = tempSide;
                            shapes[count].Name = className;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("You entered not a number!!");
                            Console.ForegroundColor = ConsoleColor.White;
                        }

                    }
                    count++;
                   
                   
                }

                if (count == userArrayLength || count > userArrayLength)
                {
                    isFull = false;
                }
                if (className == "Display")
                {
                    for (int i = 0; i < count; i++)
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("{0} ", shapes[i].Name);
                        if (shapes[i] is Circle)
                        {
                            Console.WriteLine($"Circle property:{((Circle)shapes[i]).Radius}");
                        }
                        else if (shapes[i] is Square)
                        {
                            Console.WriteLine($"Square property:{((Square)shapes[i]).Side}");

                        }
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
            }

            for (int i = 0; i < shapes.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("{0} ", shapes[i].Name);
                if (shapes[i] is Circle)
                {
                    Console.WriteLine($"Circle property:{((Circle)shapes[i]).Radius}");
                }
                else if (shapes[i] is Square)
                {
                    Console.WriteLine($"Square property:{((Square)shapes[i]).Side}");

                }
            }
            Console.ReadKey();
        }
    }
}



