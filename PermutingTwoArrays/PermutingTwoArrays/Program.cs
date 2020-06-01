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

public class ReverseComparer : IComparer<int>
{
    public int Compare(int x, int y)
    {
        if (x == y)
            return 0;
        else if (x < y)
            return 1;
        else
            return -1;
    }
}

class Solution
{

    // Complete the twoArrays function below.
    static string twoArrays(int k, int[] A, int[] B)
    {

        Array.Sort(A);
        Array.Sort(B, new ReverseComparer());

        for (int i = 0; i < A.Length; i++)
            if (A[i] + B[i] < k)
                return "NO";

        return "YES";

    }

    static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int q = Convert.ToInt32(Console.ReadLine());

        for (int qItr = 0; qItr < q; qItr++)
        {
            string[] nk = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nk[0]);

            int k = Convert.ToInt32(nk[1]);

            int[] A = Array.ConvertAll(Console.ReadLine().Split(' '), ATemp => Convert.ToInt32(ATemp));

            int[] B = Array.ConvertAll(Console.ReadLine().Split(' '), BTemp => Convert.ToInt32(BTemp));
            string result = twoArrays(k, A, B);

            //textWriter.WriteLine(result);
            Console.WriteLine(result);
        }

        //textWriter.Flush();
        //textWriter.Close();
        Console.ReadKey();
    }
}
