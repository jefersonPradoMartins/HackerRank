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
     * Complete the 'diagonalDifference' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY arr as parameter.
     */

    public static int diagonalDifference(List<List<int>> arr)
    {
        
        int leftoright = 0;
        int rightoleft = 0;
       
        for(int i = 0; i < arr.Count;i++)
        {
            for(int j  = 0; j < arr[i].Count; j++)
            {
                if(i == j)
                {
                    leftoright = leftoright + arr[i][j];
                }
            }
        }
        for(int i = 0; i < arr.Count; i++)
        {
            for(int j = 0; j < arr[i].Count; j++)
            {
                if(i + j == arr.Count-1)
                {
                    rightoleft = rightoleft + arr[i][j];
                }
            }
        }
        var result = 0;
        if (leftoright > rightoleft)
        {
             result = leftoright - rightoleft;
        }
        else
        {
             result = rightoleft - leftoright;
        }
        
        return result;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@"C:\REDE\rede.txt");

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<List<int>> arr = new List<List<int>>();

        for (int i = 0; i < n; i++)
        {
            arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
        }

        int result = Result.diagonalDifference(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
