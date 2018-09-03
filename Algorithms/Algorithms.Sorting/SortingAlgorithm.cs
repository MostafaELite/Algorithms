using System;

namespace Algorithms.Sorting
{
    public abstract class SortingAlgorithm
    {
        public abstract int[] Sort(int[] unsortedArray);

        protected void Swap(int[] unsortedArray, int i, int j)
        {
            var temp = unsortedArray[i];
            unsortedArray[i] = unsortedArray[j];
            unsortedArray[j] = temp;
        }
    }
}
