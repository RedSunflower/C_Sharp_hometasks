using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask1
{
    class Item
    {
        public string Item_Name;
        public int Index;
        public int Value;
        public Item() {

        }
        public Item(string Item_Name, int Index, int Value) {

            this.Item_Name = Item_Name;// element in brackets is assigned to exactly defined filed of a class
            this.Index = Index;
            this.Value = Value;
        }

        
        public int Code { get; set; }
        public int Color { get; set; }
        public int Length { get; set;}
        
        //public override string ToString()
        //{
        //    return Code.ToString();
        //}

    }
}
