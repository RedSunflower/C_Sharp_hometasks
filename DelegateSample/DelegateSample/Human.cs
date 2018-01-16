using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateSample
{
    class Human
    {
        public String Name; 
        public int Age;

        public Human(String name, int age)
        {
             Name = name;
             Age = age;
        }
        
        public void GetInfo()
        {
            Console.WriteLine($"This is {Name} he or she is {Age}");
            
        }
    }
}
