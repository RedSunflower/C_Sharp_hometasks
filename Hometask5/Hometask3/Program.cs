using System;
using System.Collections.Generic;
using System.Globalization;
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
            // int userArrayLength = GetInt("Please enter number of elements ");
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
            var GenShape = new GenericShape<Shape>(userArrayLength);
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
                    GenShape.Add(new Circle(), count);
          
                    Console.WriteLine(" Enter radius value : ");
                    string radius = Console.ReadLine();
                    double tempR;
                    bool isRNumber = double.TryParse(radius, NumberStyles.Any, CultureInfo.InvariantCulture, out tempR);
                    if (GenShape.GetItem(count) is Circle)
                    {

                        if (isRNumber)
                        {
                            ((Circle)GenShape.GetItem(count)).Radius = tempR;
                            GenShape.GetItem(count).Name = className;
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
                    GenShape.Add(new Square(), count);
                    Console.WriteLine(" Enter side value : ");
                    string side = Console.ReadLine();
                    double tempSide;
                    bool isSNumber = double.TryParse(side, out tempSide);
                    if (GenShape.GetItem(count) is Square)
                    {
                        if (isSNumber)
                        {
                            ((Square)GenShape.GetItem(count)).Side = tempSide;
                            GenShape.GetItem(count).Name = className;
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
                        Console.WriteLine("{0} ", GenShape.GetItem(i).Name);
                        if (GenShape.GetItem(i) is Circle)
                        {
                            Console.WriteLine($"Circle property:{((Circle)GenShape.GetItem(i)).Radius}");
                        }
                        else if (GenShape.GetItem(i) is Square)
                        {
                            Console.WriteLine($"Square property:{((Square)GenShape.GetItem(i)).Side}");

                        }
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
            }
            int l = GenShape.GetArrayLength();
            for (int i = 0; i < l; i++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("{0} ", GenShape.GetItem(i).Name);
                if (GenShape.GetItem(i) is Circle)
                {
                    Console.WriteLine($"Circle property:{((Circle)GenShape.GetItem(i)).Radius}");
                }
                else if (GenShape.GetItem(i) is Square)
                {
                    Console.WriteLine($"Square property:{((Square)GenShape.GetItem(i)).Side}");

                }
            }
            Console.ReadKey();
        }

        public static int GetInt(string userText)
        {
            int result = 0;
            bool isNumber = false;
            while (isNumber)
            {
                Console.WriteLine(userText);
                isNumber = int.TryParse(Console.ReadLine(), out result);
                if(!isNumber)
                    Console.WriteLine("Error");
            }
            return result;
        }
    }
}



