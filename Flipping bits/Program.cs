using System.CodeDom.Compiler;
using System.Collections.Generic;
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
using System.Collections;

class Result
{

    /*
     * Complete the 'flippingBits' function below.
     *
     * The function is expected to return a LONG_INTEGER.
     * The function accepts LONG_INTEGER n as parameter.
     */

    public static long flippingBits(long n)
    {

        BitArray bitArrays = new BitArray(new int[] { (int)n });
        //  byte[] bitArray = BitConverter.GetBytes (n);

        for (int i = 0; i < bitArrays.Length; i++)
        {
            if (bitArrays[i] == true)
            {
                bitArrays.Set(i,false);
            }
            else
            {
                bitArrays.Set(i, true);
            }
        }

        var sb = new StringBuilder();

        for(int i = 0; i < bitArrays.Length; i++)
        {
            char c = bitArrays[i]?'1':'0';
            sb.Append(c);
        }

        var result = Convert.ToUInt32(sb.ToString(),2); ;


        return (long)result;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter("c:\\rede\\rede.txt");

        //  int q =  Convert.ToInt32(Console.ReadLine().Trim());

        //for (int qItr = 0; qItr < q; qItr++)
        //{
        //long n =  Convert.ToInt64(Console.ReadLine().Trim());

        // long result = Result.flippingBits(n);
          long result = Result.flippingBits(Convert.ToInt64(2147483647));
         result = Result.flippingBits(Convert.ToInt64(1));
        result = Result.flippingBits(Convert.ToInt64(0));

        textWriter.WriteLine(result);
        //}

        textWriter.Flush();
        textWriter.Close();
    }
}
