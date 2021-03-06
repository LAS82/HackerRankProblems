﻿using System.CodeDom.Compiler;
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

    // Complete the birthday function below.
    static int birthday(List<int> s, int d, int m)
    {
        int sumForTest;
        int res = 0;

        for (int i = 0; (i + m) <= s.Count; ++i)
        {
            sumForTest = 0;
            for (int j = i; j <= (i + m - 1); ++j)
                sumForTest += s[j];

            if (sumForTest == d)
                res++;
        }

        return res;
    }

    static void Main(string[] args)
    {
        

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> s = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(sTemp => Convert.ToInt32(sTemp)).ToList();

        string[] dm = Console.ReadLine().TrimEnd().Split(' ');

        int d = Convert.ToInt32(dm[0]);

        int m = Convert.ToInt32(dm[1]);

        int result = birthday(s, d, m);

        //to run on visual studio
        Console.WriteLine(result);
        Console.ReadKey();

        /*
        //To run on hackerrank
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
        */
    }
}
