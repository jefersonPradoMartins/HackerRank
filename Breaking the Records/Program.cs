﻿using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'breakingRecords' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY scores as parameter.
     */

    public static List<int> breakingRecords(List<int> scores)
    {
        var scoreMinimum = scores[0];
        var scoreMax = scores[0];
        var contMin = 0; var contMax = 0;

        for(int i=0; i< scores.Count(); i++)
        {          

            if (scores[i] < scoreMinimum)
            {
                contMin = contMin+1;
                scoreMinimum = scores[i];
            }
            else if (scores[i] > scoreMax)
            {
                contMax = contMax+1;
                scoreMax = scores[i];
            }

          
        }
        List<int> result = new List<int>();
        result.Add(contMax);
        result.Add(contMin);

        return result;
        
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter("c:\\rede\\rede.txt");

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> scores = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(scoresTemp => Convert.ToInt32(scoresTemp)).ToList();

        List<int> result = Result.breakingRecords(scores);
        textWriter.WriteLine(String.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
