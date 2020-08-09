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

    // Complete the hurdleRace function below.
    static int hurdleRace(int k, int[] height)
    {
        int taller = 0;

        for (int i = 0; i < height.Length; ++i)
            if (taller < height[i])
                taller = height[i];

        int numberOfPotions = taller - k;

        return numberOfPotions < 0 ? 0 : numberOfPotions;
    }

    static void Main(string[] args)
    {
        string[] nk = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nk[0]);

        int k = Convert.ToInt32(nk[1]);

        int[] height = Array.ConvertAll(Console.ReadLine().Split(' '), heightTemp => Convert.ToInt32(heightTemp));

        int result = hurdleRace(k, height);


        /*
        //To run on hackerrack
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();*/

        //To run on visual studio
        Console.WriteLine(result);
    }
}
