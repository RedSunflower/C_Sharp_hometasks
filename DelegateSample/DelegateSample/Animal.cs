using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateSample
{
    class Animal
    {
        public String Species;
        public String Habitat;
        public Animal(String species, String habitat)
        {
            Species = species;
            Habitat = habitat;
        }
        public void GetInfo()
        {
            Console.WriteLine($"This is {Species} it lives in {Habitat}");

        }
    }
}
