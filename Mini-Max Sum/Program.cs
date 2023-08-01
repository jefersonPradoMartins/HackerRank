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
     * Complete the 'miniMaxSum' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void miniMaxSum(List<int> arr)
    {
        Int64 minNumber = arr[0];
        Int64 minNumberIndex = 0;
        Int64 maxNumber = arr[0];
        Int64 maxNumberIndex = 0;
        Int64 sumMaxNumber = 0;
        Int64 sumMinNumber = 0;


       

        for(int i=0; i<arr.Count; i++)
        {
            if ( arr[i] < minNumber) {
            minNumber = arr[i];
                minNumberIndex = i;
            }
            else if (arr[i] > maxNumber)
            {
                maxNumber = arr[i];
                maxNumberIndex = i;
            }
        }
      

       for(int i=0 ; i<arr.Count ; i++) 
        {
            if(minNumberIndex != i )
            {
                sumMaxNumber = sumMaxNumber + arr[i];
            }
           
        }
        for (int i = 0; i < arr.Count; i++)
        {
              if (maxNumberIndex != i)
            {
                sumMinNumber = sumMinNumber + arr[i];
            }
        }

        Console.WriteLine($"{sumMinNumber} {sumMaxNumber}");

    }

}

class Solution
{
    public static void Main(string[] args)
    {

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.miniMaxSum(arr);
    }
}
