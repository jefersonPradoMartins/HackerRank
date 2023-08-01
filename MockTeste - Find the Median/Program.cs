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
     * Complete the 'findMedian' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static int bubbleSort(List<int> intList)
    {
        for (var i = intList.Count - 1; i > 0; i--)
        {
            var changes = 0;
            for (var j = 0; j < i; j++)
            {
                if (intList[j] > intList[j + 1])
                {
                    (intList[j], intList[j + 1]) = (intList[j + 1], intList[j]);
                    changes++;
                }
            }
            if (changes <= 1) break;
        }
        int r = intList[intList.Count / 2];
        return r;
    }

    public static int QuickSort(List<int> intList) => QuickSort(intList, 0, intList.Count - 1);

    public static int QuickSort(List<int> intList, int start, int end)
    {
        var pivot = intList[start];
        int l = start;
        int r = end;

        while (l <= r)
        {
            while (intList[l] < pivot) l++;
            while (intList[r] > pivot) r--;
            if (l <= r)
            {
                (intList[l], intList[r]) = (intList[r], intList[l]);
                l++;
                r--;
            }
        }
        if (start < r) QuickSort(intList, start, r);
        if (l < end) QuickSort(intList, l, end);

        return intList[intList.Count / 2];
    }

    public static int findMedian(List<int> arr)
    {
        var result = Result.QuickSort(arr);
        return result;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        int result = Result.findMedian(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}



//using System.CodeDom.Compiler;
//using System.Collections.Generic;
//using System.Collections;
//using System.ComponentModel;
//using System.Diagnostics.CodeAnalysis;
//using System.Globalization;
//using System.IO;
//using System.Linq;
//using System.Reflection;
//using System.Runtime.Serialization;
//using System.Text.RegularExpressions;
//using System.Text;
//using System;
//using System.Diagnostics;

//public class Result
//{

//    /*
//     * Complete the 'findMedian' function below.
//     *
//     * The function is expected to return an INTEGER.
//     * The function accepts INTEGER_ARRAY arr as parameter.
//     */

//    public static int QuickSort(List<int> intList) => QuickSort(intList, 0, intList.Count-1);

//    public static int QuickSort(List<int> intList, int start, int end)
//    {
//        var pivot = intList[start];
//        int l = start;
//        int r = end;

//        while(l <= r)
//        {
//            while (intList[l] < pivot) l++;
//            while (intList[r] > pivot) r--;
//        if (l <= r)
//        {
//            (intList[l], intList[r]) = (intList[r], intList[l]);
//            l++;
//            r--;
//        }
//        }
//        if(start <r) QuickSort(intList,start,r);
//        if(l< end) QuickSort(intList,l,end);

//        return intList[intList.Count/2];
//    }


//    public static int OrderByDescending(List<int> intList)
//    {
//        var result = intList.OrderByDescending(x=>x).ToArray();
//        int r = result[intList.Count/2] ;
//        return r;
//    }



//    public static int findMedian(List<int> arr)
//    {
//        int result =0;      

//        for (int i = 0; i < arr.Count; i++)
//        {
//            int minValue = arr[i]; // valor original da posição;

//            for (int j = i; j < arr.Count; j++)
//            {
//                if ( arr[j] < minValue ) {
//                    arr[i] = arr[j];

//                    arr[j] = minValue;
//                    minValue = arr[i];
//                }
//            }
//        }

//        result = arr[(arr.Count / 2) ];
//        return result;
//    }

//}

//public class Solution
//{
//    public static void Main(string[] args)
//    {
//        TextWriter textWriter = new StreamWriter("c:\\rede\\rede.txt");

//        //int n = Convert.ToInt32(Console.ReadLine().Trim());

//       // List<int> arr = new List<int>();//  {0,1,2,4,6,5,3}; // Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
//        List<int> arr = new List<int>() {0,1,2,4,6,5,3};
//        Random rand = new Random();

//        int n = 7;// rand.Next(1000000, 1000001);

//        //for (int i = 0; i < n; i++)
//        //{
//        //    arr.Add(rand.Next(-10000, 10000));
//        //}

//        //  var r = Result.quickSort(arr);
//        var watch = new Stopwatch();


//        watch.Start();
//        // var resultb = Result.bubbleSort(arr);
//       var r = Result.QuickSort(arr);
//        watch.Stop();
//        Console.WriteLine($"mid: {r} QuickSort " + watch.ElapsedMilliseconds);

//        // watch.Reset();
//        // watch.Start();
//        // var resultq = Result.quickSorts(arr);
//        // watch.Stop();
//        // Console.WriteLine($"mid: {resultq} quickSort " + watch.ElapsedMilliseconds);

//        // watch.Reset();
//        //   watch.Start();
//        // int result = Result.findMedian(arr);
//        // watch.Stop();
//        // Console.WriteLine($"mid: {result} findMedian " + watch.ElapsedMilliseconds);


//        //textWriter.WriteLine(result);

//        //textWriter.Flush();
//        //textWriter.Close();
//    }
//}
