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

    // Complete the workbook function below.
    static int workbook(int n, int k, int[] arr)
    {

        int currentPage = 1;
        int currentChapter = 0;
        int problemNumberPerPage = 0;
        int problemNumberPerChapter = 0;
        int specialProblems = 0;

        while (currentChapter < arr.Length)
        {
            for (int i = 0; i < arr[currentChapter]; ++i)
            {
                problemNumberPerPage++;
                problemNumberPerChapter++;

                if (problemNumberPerChapter == currentPage)
                    specialProblems++;

                if (problemNumberPerPage == k && i < arr[currentChapter] - 1)
                {
                    currentPage++;
                    problemNumberPerPage = 0;
                }

            }

            currentChapter++;
            currentPage++;
            problemNumberPerChapter = 0;
            problemNumberPerPage = 0;
        }

        return specialProblems;

    }

    static void Main(string[] args)
    {
        

        string[] nk = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nk[0]);

        int k = Convert.ToInt32(nk[1]);

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        int result = workbook(n, k, arr);

        //To run on visual studio
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
