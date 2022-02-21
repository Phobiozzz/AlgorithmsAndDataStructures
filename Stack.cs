using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAnsDataStructures
{
    internal class Stack<T>
    {
        private List<T> elements;
        public void Push( T _data)
        {
            if (elements == null)
            { 
                elements = new List<T>();
            }
            elements.Add(_data);
        }

        public T Pop()
        {
            T data = elements[elements.Count - 1];
            elements.RemoveAt(elements.Count - 1);
            return data;
        }
        public T Peek()
        { 
            return elements[elements.Count - 1];
        }
        public int Count()
        { 
            return elements.Count;  
        }

        public void Print()
        {
            string stack = "";
            for (int i = 0; i < elements.Count; i++)
            { 
                stack += " " + elements[i].ToString();
            }
            Console.WriteLine(stack);
        }

        public bool Contains(T _data)
        { 
            return (elements.Contains(_data));
        }
        public T[] ToArray()
        { 
            T[] array = new T[elements.Count];
            for (int i = 0; i < elements.Count; i++)
            { 
                array[i] = elements[i];
            }
            return array;
        }
    }
}
