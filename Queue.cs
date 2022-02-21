using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAnsDataStructures
{
    internal class Queue<T>
    {
        public List<T> elements;
        public void Enqueue(T _data)
        {
            if (elements == null)
            { 
               elements = new List<T>();
            }
            elements.Add(_data);
        }
        public T Dequeue()
        {
            T data = elements[0];
            elements.RemoveAt(0);
            return data;
        }
        public void Print()
        {
            string queue = "";
            foreach (T data in elements)
            {
                queue += " " + data; 
            }
            Console.WriteLine(queue);
        }

    }
}
