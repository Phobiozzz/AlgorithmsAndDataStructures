using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAnsDataStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] testArray = new int[] { 11, 8, 9, 20, 0, 12, 7, 5, 0 };

            Algorithms algorithms = new Algorithms();
            Console.WriteLine("Array before sorting: " + algorithms.PrintArray(testArray));
            //algorithms.BubbleSort(testArray);
            //algorithms.InsertionSort(testArray);
            //algorithms.MergeSort(testArray);
            algorithms.QuickSort(testArray, 0, testArray.Length - 1);
            Console.WriteLine("Array after sorting: " + algorithms.PrintArray(testArray));
            LinkedList<int> list = new LinkedList<int>();
            list.Add(11);
            list.Add(8);
            list.Add(9);
            list.Print();
            Console.WriteLine(list.Contains(11));
            Console.WriteLine(list.Contains(40));
            list.Remove(9);
            
            list.Print();

            Stack<int> stack = new Stack<int>();
            stack.Push(123);
            stack.Push(321);
            stack.Push(20);
            stack.Print();
            int temp = stack.Pop();
            temp = stack.Peek();
            Console.WriteLine(stack.Count());
            int[] array = stack.ToArray();

            for (int i = 0; i < array.Length; i++)
            { 
                Console.WriteLine(array[i]);
            }
            stack.Print();

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(42);
            queue.Enqueue(43);
            queue.Enqueue(44);
            queue.Print();
            queue.Dequeue();
            queue.Dequeue();
            queue.Print();
            Console.ReadLine();
        }
    }
}
