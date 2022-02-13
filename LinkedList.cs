using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAnsDataStructures
{
    internal class LinkedList<T>
    {
        private Node<T> head;
        private Node<T> tail;

        private int count;

        public void Add(T _data)
        {
            Node<T> node = new Node<T>(_data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                tail.nextNode = node;
            }
            tail = node;
            count++;
        }

        public void Print()
        {
            Node<T> currentNode = head;
            string listStr = "";
            while (currentNode != null)
            {
                listStr += currentNode.data + " ";
                currentNode = currentNode.nextNode;
            }
            Console.WriteLine(listStr);
        }
    }
}
