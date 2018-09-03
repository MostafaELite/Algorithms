using Algorithms.Sorting;
using System;

namespace Run
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new[] { 7, 2, 8, 5, 6, 4, 1 };
            SortingAlgorithm sortingAlgorithm = new BubbleSort();
            var sortedArray = sortingAlgorithm.Sort(numbers);
            foreach (var number in sortedArray)
                Console.WriteLine(number);
            Console.Read();

        }
    }
}
