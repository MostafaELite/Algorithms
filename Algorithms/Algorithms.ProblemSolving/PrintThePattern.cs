using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.ProblemSolving
{
    public class PrintThePattern : IProblem
    {
        public string Description => "You a given a number N. You need to print the pattern for the given value of N.";

        public string Example => @"for N=2 the pattern will be 2 2 1 1
                                                               2 1
                                   for N=3 the pattern will be 
                                   3 3 3 2 2 2 1 1 1
                                   3 3 2 2 1 1
                                   3 2 1";
        //Output Format:
        //For each test case, in a new line, print the required pattern in a singleline.
        //Note : Instead of printing new line print a "$" without quotes."

        public string PrintPattern(int n)
        {
            string result = "";
            for (int currentLine = n; currentLine > 0; currentLine--)
            {
                string line = "";
                for (int numberToRepeat = n; numberToRepeat > 0; numberToRepeat--)
                {
                    for (int numberOfReps = currentLine; numberOfReps > 0; numberOfReps--)
                        line += numberToRepeat;
                }
                result += line + "$";

            }
            return result;
        }

    }
}
