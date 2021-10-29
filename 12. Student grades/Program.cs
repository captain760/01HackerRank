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
     * Complete the 'gradingStudents' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY grades as parameter.
     */

    public static List<int> gradingStudents(List<int> grades)
    {
        List<int> newGrades = new List<int>();
        for (int i = 0; i < grades.Count; i++)
        {
            
            if (grades[i]>=38)
            {
                if (grades[i] % 5 == 0)
                {
                    newGrades.Add(grades[i]);
                }
                else
                {

                    int next5 = (grades[i] / 5)*5 + 5;
                    if ((next5 -grades[i])>=3)
                    {
                        newGrades.Add(grades[i]);
                    }
                    else
                    {
                        newGrades.Add(next5);
                    }
                }
            }
            else
            {
                newGrades.Add(grades[i]);
            }
        }
        return newGrades;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        

        int gradesCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> grades = new List<int>();

        for (int i = 0; i < gradesCount; i++)
        {
            int gradesItem = Convert.ToInt32(Console.ReadLine().Trim());
            grades.Add(gradesItem);
        }

        List<int> result = Result.gradingStudents(grades);

        Console.WriteLine(String.Join("\n", result));

        
    }
}
