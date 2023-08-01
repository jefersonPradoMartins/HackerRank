using System.CodeDom.Compiler;
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
     * Complete the 'divisibleSumPairs' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. INTEGER k
     *  3. INTEGER_ARRAY ar
     */

    public static int divisibleSumPairs(int n, int k, List<int> ar)
    {
        var cont = 0;
        List<int> tempValor = new List<int>();
        
        for(int i = 0; i < ar.Count; i++)
        {
            tempValor.Add(ar[i]);
            tempValor.Add(i);

            for(int j = 0; j < ar.Count; j++)
            {
                if ( j > tempValor[1])
                {
                    if ((tempValor[0] + ar[j]) % k ==0 )
                    {
                        cont ++;
                    }
                }
            }
            tempValor.Clear();
        }
        return cont;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter("c:\\rede\\rede.txt");

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(firstMultipleInput[0]);

        int k = Convert.ToInt32(firstMultipleInput[1]);

        List<int> ar  = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();

       int result = Result.divisibleSumPairs(n, k, ar);
   

        Console.WriteLine(result);
        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
