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
     * Complete the 'timeConversion' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string timeConversion(string s)
    {
        int hrs = int.Parse(s[0].ToString() + s[1].ToString());
        string min = s[3].ToString() + s[4].ToString();
        string sec = s[6].ToString() + s[7].ToString();
        
        if (s[8] == 'P' && hrs!=12)
        {
            hrs += 12;
        }
        if (s[8] == 'A' && hrs == 12)
        {
            hrs -= 12;
        }
        string hours = "";
        if (hrs<10)
        {
            hours = "0" + hrs.ToString();
        }
        else
        {
            hours = hrs.ToString();
        }
        return (hours + ":" + min + ":" + sec);
    }

}

class Solution
{
    public static void Main(string[] args)
    {


        string s = Console.ReadLine();

        string result = Result.timeConversion(s);

        Console.WriteLine(result);


    }
}
