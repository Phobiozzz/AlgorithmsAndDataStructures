﻿using System;
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
            Console.ReadLine();
        }
    }
}
