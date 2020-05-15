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

    // Complete the divisibleSumPairs function below.
    static int divisibleSumPairs(int n, int k, int[] ar)
    {

        return 0;

    }

    static void Main(string[] args)
    {
        

        string[] nk = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nk[0]);

        int k = Convert.ToInt32(nk[1]);

        int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));
        int result = divisibleSumPairs(n, k, ar);

        //to run on visual studio
        Console.WriteLine(result);
        Console.ReadKey();

        /*
        //to run on hackerrank
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
        */
    }
}
