using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAnsDataStructures
{
    public class Algorithms
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

        public void MergeSort(int[] _array)
        {
            //Works on O(nlogn)
            if (_array.Length < 2)
            {
                return;
            }
            //Split array twice
            int[] leftSide = new int[_array.Length/2];
            int[] rightSide = new int[_array.Length - leftSide.Length];

            for (int i = 0; i < leftSide.Length; i++)
            { 
                leftSide[i]  = _array[i];
            }

            for (int j = leftSide.Length; j < _array.Length; j++)
            { 
                rightSide[j- leftSide.Length] = _array[j];
            }
            MergeSort(leftSide);
            MergeSort(rightSide);
            Merge(_array, leftSide, rightSide);
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

        private void Merge(int[] _targetArray, int[] _firstArray, int[] _secondArray)
        {
            int targetArrayCurrent = 0;
            int firstArrayCurrent = 0;
            int secondArrayCurrent = 0;

            while (firstArrayCurrent < _firstArray.Length && secondArrayCurrent < _secondArray.Length)
            {
                if (_firstArray[firstArrayCurrent] <= _secondArray[secondArrayCurrent])
                {
                    _targetArray[targetArrayCurrent] = _firstArray[firstArrayCurrent];
                    firstArrayCurrent++;
                }
                else
                { 
                    _targetArray[targetArrayCurrent] = _secondArray[secondArrayCurrent];
                    secondArrayCurrent++;
                }
                targetArrayCurrent++;
            }
            while (firstArrayCurrent < _firstArray.Length)
            {
                _targetArray[targetArrayCurrent] = firstArrayCurrent;
                firstArrayCurrent++;
                targetArrayCurrent++;
            }
            while (secondArrayCurrent < _secondArray.Length)
            {
                _targetArray[targetArrayCurrent] = _secondArray[secondArrayCurrent];
                secondArrayCurrent++;
                targetArrayCurrent++;
            }
        }
    }
}
