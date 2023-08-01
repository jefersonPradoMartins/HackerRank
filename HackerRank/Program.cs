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
using System.Xml;

class Result
{

    /*
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
   +  */

    public static void plusMinus(List<int> arr)
    {
        foreach (int i in arr)
        {
            Console.WriteLine(i);
        }

        decimal numberOfElements = arr.Count;
        decimal numberOfPositiveElements = 0;
        decimal numberOfNegativeElements = 0;
        decimal numberOfZeroElements = 0;

        decimal proportionOfPositive = 0;
        decimal proportionOfNegative = 0;
        decimal proportionOfZero = 0;


        foreach (int element in arr)
        {
            if (element > 0)
            {
                numberOfPositiveElements++;
            }
            else if (element < 0)
            {
                numberOfNegativeElements++;
            }
            else if (element == 0)
            {
                numberOfZeroElements++;
            }
        }

        proportionOfPositive = (numberOfPositiveElements / numberOfElements);
        proportionOfNegative = (numberOfNegativeElements / numberOfElements);
        proportionOfZero = (numberOfZeroElements / numberOfElements);


        Console.WriteLine(proportionOfPositive.ToString("0.000000", CultureInfo.InvariantCulture));
        Console.WriteLine(proportionOfNegative.ToString("0.000000", CultureInfo.InvariantCulture));
        Console.WriteLine(proportionOfZero.ToString("0.000000", CultureInfo.InvariantCulture));



    }

}

class Solution
{
    public static void Main(string[] args)
    {
        //int a = 2;
        //int b = 5;
        //decimal c = a;
        //decimal d = b;

        //Console.WriteLine(c/d);
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}
