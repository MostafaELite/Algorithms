using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Sorting
{
    public class SelectionSort : SortingAlgorithm
    {
        public override int[] Sort(int[] unsortedArray)
        {
            // i represents also the last index of the sorted part of the array
            for (int i = 0; i < unsortedArray.Length; i++)
            {
                int minIndex = i;
                for (int j = i; j < unsortedArray.Length; j++)
                    if (unsortedArray[minIndex] > unsortedArray[j])
                        minIndex = j;
                Swap(unsortedArray, i, minIndex);
            }
            return unsortedArray;
        }
    }
}
