using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAnsDataStructures
{
    public class Node<T>
    {
        public Node(T _data)
        {
            data = _data;
        }
       public T data { get; set; }
       public Node<T> nextNode { get; set; }
    }
}
