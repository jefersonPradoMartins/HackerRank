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
     * Complete the 'countingSort' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static List<int> countingSort(List<int> arr)
    {
        Dictionary<int,int> arrDictionary = new Dictionary<int,int>();

        for(int i=0; i< arr.Count; i++)
        {
            if (arrDictionary.ContainsKey(arr[i]))
            {
                arrDictionary[arr[i]]++;
            }
            else
            {
                arrDictionary.Add(arr[i], 0);
            }
        }

        List<int> result = new List<int>(); 
       
        
        foreach(int i in arrDictionary.Values)
        {
            result.Add(i);
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
       
        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
        
       
        
        List<int> result = Result.countingSort(arr);

        textWriter.WriteLine(String.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
