﻿using Algorithms.ProblemSolving;
using Algorithms.Sorting;
using System;

namespace Run
{
    class Program
    {
        static void Main(string[] args)
        {
            //var numbers = new[] { 7, 2, 8, 5, 6, 4, 1 };
            //SortingAlgorithm sortingAlgorithm = new SelectionSort();            
            //var sortedArray = sortingAlgorithm.Sort(numbers);
            //foreach (var number in sortedArray)
            //    Console.WriteLine(number);

            //var transofrmString = new TransformStringIntoAnother();
            //Console.WriteLine(transofrmString.Transform("pincel", "pinwww"));

            var printThePattern = new PrintThePattern();
            Console.WriteLine(printThePattern.PrintPattern(3));
            Console.Read();

        }
    }

}
