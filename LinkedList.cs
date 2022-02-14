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

        public void Remove(T _data)
        {
            Node<T> current = head;
            Node<T> previous = null;
            while (current != null)
            {
                if (current.data.Equals(_data))
                {
                    if (previous == null)
                    {
                        head = current.nextNode;
                        if (head == null)
                        {
                            tail = null;
                        }
                    }
                    else
                    {
                        previous.nextNode = current.nextNode;
                        if (current.nextNode == null)
                        {
                            tail = previous;
                        }
                    }
                    count--;
                }
                previous = current;
                current = current.nextNode;
            }
        }

        public int Count()
        { 
            return count;
        }

        public bool Contains(T _data)
        {
            Node<T> node = head;
            while (node != null)
            {
                if (node.data.Equals(_data))
                { 
                    return true;
                }
                node = node.nextNode;
            }
            return false;
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
