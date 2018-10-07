using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.ProblemSolving
{
    public class TransformStringIntoAnother : IProblem
    {
        public string Description => "Given two strings ‘str1’ and ‘str2’ of size m and n respectively." +
            "The task is to remove/delete and insert minimum number of characters from/in str1 so as to transform it into str2";

        public string Example => "Input:str1 ='heap', str2 = 'pea' Output : Deletion = 2 ,Insertion = 1";

        public string Transform(string str1, string str2)
        {
            int deletion = 0, insertion = 0;

            for (int i = 0; i < str1.Length && i < str2.Length ; i++)
                if (str1[i] != str2[i])
                {
                    insertion++;
                    deletion++;
                }
            var lengthDifference = str1.Length - str2.Length;
            if (lengthDifference > 0) // if the first string is longer than the second string then we will need to delete the remaining chars
                deletion += lengthDifference;
            else // if the first string is shorter than the second string then we will need to insert the remaining chars
                insertion += (lengthDifference * -1);

            return $"{deletion} Deletion and {insertion} Insertion Required";
        }

    }
}
