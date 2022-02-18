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
            // Works on O(nlogn)
            //Exit condition
            if (_array.Length < 2)
            {
                return;
            }

            //Spliting array into two parts
            int leftPartLength = _array.Length / 2;
            int rightPartLength = _array.Length - leftPartLength;
            int[] leftPart = new int[leftPartLength];
            int[] rightPart = new int[rightPartLength];
            //Fill both parts

            for (int i = 0; i < leftPartLength; i++)
            {
                leftPart[i] = _array[i];
            }
            for (int i = 0; i < rightPart.Length; i++)
            {
                rightPart[i] = _array[(i + leftPartLength)];
            }
            //Recursive split of left and right parts
            MergeSort(leftPart);
            MergeSort(rightPart);
            //Merge parts
            Merge(_array, leftPart, rightPart);

        }

        public void QuickSort(int[] _array, int _from, int _to)
        {
            //Exit Condition
            if (_from >= _to)
            {
                return;
            }
            int point = Partition(_array, _from, _to);
            QuickSort(_array, _from, point - 1);
            QuickSort(_array, point + 1, _to);
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
            int firstArrayMin = 0;
            int secondArrayMin = 0;
            int targetArrayMin = 0;
            while (firstArrayMin < _firstArray.Length && secondArrayMin < _secondArray.Length)
            {
                if (_firstArray[firstArrayMin] >= _secondArray[secondArrayMin])
                {
                    _targetArray[targetArrayMin] = _secondArray[secondArrayMin];
                    secondArrayMin++;
                }
                else
                {
                    _targetArray[targetArrayMin] = _firstArray[firstArrayMin];
                    firstArrayMin++;
                }
                targetArrayMin++;
            }
            
            while (firstArrayMin < _firstArray.Length)
            {
                _targetArray[targetArrayMin] = _firstArray[firstArrayMin];
                targetArrayMin++;
                firstArrayMin++;
            }
            while (secondArrayMin < _secondArray.Length)
            {
                _targetArray[targetArrayMin] = _secondArray[secondArrayMin];
                targetArrayMin++;
                secondArrayMin++;
            }

        }

        private int Partition(int[] _array, int _from, int _to)
        {
            int pivot = _from;
            for (int currentItem = _from; currentItem < _to; currentItem++)
            {
                if (_array[currentItem] <= _array[_to])
                {
                    Swap(_array, currentItem, pivot);
                    pivot++;
                }
            }
            Swap(_array, pivot, _to);
            return pivot;
        }
    }
}
