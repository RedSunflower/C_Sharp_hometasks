using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateSample
{
    class Program
    {
        delegate List<Human> dFind(List<Human> somelist, String somestring);
        delegate List<Animal> aFind(List<Animal> somelist, String somestring);
        static void Main(string[] args)
        {
            Human Tanya = new Human("Tanya", 24);
            Human Max = new Human("Max", 30);
            Human Nazar = new Human("Nazar", 19);
            List <Human> people = new List<Human>();
            people.Add(Tanya);
            people.Add(Max);
            people.Add(Nazar);
            
            Animal Shark = new Animal("Shark", "Ocean");
            Animal Wolf = new Animal("Wolf", "Forest");
            Animal Goat = new Animal("Goat", "Mountatins");
            List<Animal> animals = new List<Animal>();
            animals.Add(Shark);
            animals.Add(Wolf);
            animals.Add(Goat);
            
            dFind selectedHuman = Find;
            selectedHuman(people, "a");
            aFind selectedAnimal = Find;
            selectedAnimal(animals, "t");

            
            Console.ReadKey();

        }
        static  List<Human> Find(List<Human> people, String somestring)
        {
            List<Human> selected = new List<Human>();
            foreach (Human human in people)
            {
                if ((human.Name).Contains(somestring))
                {
                    selected.Add(human);
                    human.GetInfo();
                }
               
            }

            
            return selected;
        }
        static List<Animal> Find(List<Animal> people, String somestring)
        {
            List<Animal> selected = new List<Animal>();
            foreach ( Animal animal in people)
            {
                if ((animal.Species).Contains(somestring) || (animal.Habitat).Contains(somestring))
                {
                    selected.Add(animal);
                    animal.GetInfo();
                }

            }


            return selected;
        }



    }
}
