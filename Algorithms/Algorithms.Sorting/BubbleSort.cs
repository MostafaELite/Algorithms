using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Sorting
{
    public class BubbleSort : SortingAlgorithm
    {
        public override int[] Sort(int[] unsortedArray)
        {
            for (int i = 0; i < unsortedArray.Length; i++)
                for (int j = i; j < unsortedArray.Length; j++)
                    if (unsortedArray[j] < unsortedArray[i])
                        Swap(unsortedArray, i, j);
            return unsortedArray;
        }
    }
}
