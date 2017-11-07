using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask1
{
    class Vehicle
    {
        public static  string WelcomeText = "This is vehicle";

        static Vehicle() {
            WelcomeText = "Hello from staic constructor";
        }
        public Vehicle() {

        }
        public class Car : Vehicle {
            public Car() {

                Console.WriteLine("Hello from Car constructor");

            }
            


        }
    }
}
