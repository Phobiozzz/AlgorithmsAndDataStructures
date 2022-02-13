using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAnsDataStructures
{
    internal class Algorithms
    {
        public void BubbleSort(int[] _array)
        {
            //Working on O(n2)
            for (int i = 0; i < _array.Length; i++)
            {
                for (int j = 0; j < _array.Length-1; j++)
                {
                    if (_array[j] > _array[j+1])
                    {
                        Swap(_array, j, j+1);
                    }
                }
            }
        }

        public void InsertionSort(int[] _array)
        {
            //Works on O(n2)
            for (int i = 0; i <= _array.Length - 1; i++)
            {
                for (int j = i + 1; j < _array.Length; j++)
                {
                    if (_array[i] >= _array[j])
                    { 
                        Swap(_array, i, j);
                    }
                }
            }
        }




        private void Swap(int[] _array, int _firstIndex, int _secondIndex)
        { 
            int temp = _array[_firstIndex];
            _array[_firstIndex] = _array[_secondIndex];
            _array[_secondIndex] = temp;
        }

        public string PrintArray(int[] _array)
        {
            string arr = " ";
            for (int i = 0; i < _array.Length; i++)
            {
                arr += _array[i] + ", ";
            }
            return arr;
        }
    }
}
