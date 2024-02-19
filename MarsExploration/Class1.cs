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
     * Complete the 'marsExploration' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts STRING s as parameter.
     */

    public static int marsExploration(string s)
    {
        int messageLength = s.Length / 3;
        int localCount = 0;
        int totalChangedLetters = 0;

        for (int i = 0; i < messageLength; i = i + 3)
        {
            if (s[i] == 'S')
            {
                localCount++;
            }
            if (s[i + 1] == 'O')
            {
                localCount++;
            }
            if (s[i + 2] == 'S')
            {
                localCount++;
            }
            totalChangedLetters = totalChangedLetters + localCount;
        }
        return totalChangedLetters;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        int result = Result.marsExploration(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
