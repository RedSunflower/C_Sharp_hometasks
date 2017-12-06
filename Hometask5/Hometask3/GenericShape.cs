using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask3
{
    public class GenericShape<T>

    {
        
        private T[] genShapes;
        public GenericShape(int size)
        {
            genShapes = new T[size];
        }
        public void Add(T item, int count)
        {
            genShapes[count] = item;

        }
        public T GetItem(int count)
        {
            return genShapes[count];

        }
        public int GetArrayLength()
        {
            int length = genShapes.Length;
            return length;
        }
      
        public T this[int index]
        {
            get
            {
                throw new NotImplementedException();
            }
        }

    }
}
