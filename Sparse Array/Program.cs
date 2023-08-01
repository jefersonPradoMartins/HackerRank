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
     * Complete the 'matchingStrings' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. STRING_ARRAY strings
     *  2. STRING_ARRAY queries
     */

    public static List<int> matchingStrings(List<string> strings, List<string> queries)
    {
        List<string> tempValue = new List<string>();
        List<int> result = new List<int>();
        int cont = 0;

        for (int i = 0; i < queries.Count; i++)
        {
            tempValue.Add(queries[i]);
            tempValue.Add(i.ToString());

            for (int j = 0; j < strings.Count; j++)
            {
                if (strings[j].ToString() == tempValue[0].ToString())
                {
                    cont++;

                }
            }
            result.Add(cont);
            tempValue.Clear();
            cont = 0;
        }
        return result;

    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter("c:\\rede\\rede.txt");

        //int stringsCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<string> strings = new List<string>();

        //for (int i = 0; i < stringsCount; i++)
        //{
        //    string stringsItem = Console.ReadLine();
        //    strings.Add(stringsItem);
        //}

        //int queriesCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<string> queries = new List<string>();

        //for (int i = 0; i < queriesCount; i++)
        //{
        //    string queriesItem = Console.ReadLine();
        //    queries.Add(queriesItem);
        //}

        strings = new List<string> {"ab","ab","abc" };
        queries = new List<string> {"ab","abc","be"};

        List<int> res = Result.matchingStrings(strings, queries);

        textWriter.WriteLine(String.Join("\n", res));

        textWriter.Flush();
        textWriter.Close();
    }
}
