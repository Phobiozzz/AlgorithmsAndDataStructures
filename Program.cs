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
            algorithms.BubbleSort(testArray);
            Console.WriteLine("Array after sorting: " + algorithms.PrintArray(testArray));
            Console.ReadLine();
        }
    }
}
