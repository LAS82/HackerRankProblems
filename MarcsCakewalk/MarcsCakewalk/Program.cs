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

class Solution
{

    // Complete the marcsCakewalk function below.
    static long marcsCakewalk(int[] calorie)
    {
        long minWalkLen = 0;
        Array.Sort(calorie);

        for (int i = calorie.Length - 1; i >= 0; --i)
            minWalkLen += Convert.ToInt64(Math.Pow(2, calorie.Length - i - 1) * calorie[i]);

        return minWalkLen;
    }

    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());

        int[] calorie = Array.ConvertAll(Console.ReadLine().Split(' '), calorieTemp => Convert.ToInt32(calorieTemp));
        long result = marcsCakewalk(calorie);


        //to run on visual studio
        Console.WriteLine(result);
        Console.ReadKey();

        /*
        //To run on hacker rank
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
        */
    }
}
