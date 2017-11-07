using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Item item = new Item();
            Item item2 = new Item("orange", 10,2);
            item.Item_Name = "banana";
            item.Index = 10;
            Console.WriteLine("This is "+item.Item_Name);
            Console.WriteLine("This is " + item2.Item_Name);
            Console.ReadKey();
        }
    }
}
