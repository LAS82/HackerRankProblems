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

    // Complete the maximizingXor function below.
    static int maximizingXor(int l, int r)
    {

        return 0;

    }

    static void Main(string[] args)
    {
        

        int l = Convert.ToInt32(Console.ReadLine());

        int r = Convert.ToInt32(Console.ReadLine());

        int result = maximizingXor(l, r);

        //to run on visual studio
        Console.WriteLine(result);
        Console.ReadKey();

        /*
        // To run on hackerrank
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
        */
    }
}
