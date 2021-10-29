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
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {
        int positives = 0;
        int negatives = 0;
        int zeroes = 0;
        

        foreach (int item in arr)
        {
            if (item > 0)
            {
                positives++;
            }
            else if (item<0)
            {
                negatives++;
            }
            else
            {
                zeroes++;
            }
        }
        decimal posRel = 1.0M*positives / arr.Count;
        decimal negRel = 1.0M * negatives / arr.Count;
        decimal zerRel = 1.0M * zeroes / arr.Count;
        Console.WriteLine($"{posRel:f6}");
        Console.WriteLine($"{negRel:f6}");
        Console.WriteLine($"{zerRel:f6}");
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}
