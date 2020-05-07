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
    public static int findMinimumBirdTypeWithMaximumFrequency(Dictionary<int, int> frequenciesByBirdType)
    {
        int birdType = 0;
        int birdValue = 0;

        for (int i = 5; i > 0; --i)
        {
            if (frequenciesByBirdType[i] >= birdValue)
            {
                birdType = i;
                birdValue = frequenciesByBirdType[i];
            }
        }        

        return birdType;
    }

    // Complete the migratoryBirds function below.
    static int migratoryBirds(List<int> arr)
    {

        Dictionary<int, int> frequenciesByBirdType =
            new Dictionary<int, int>(5);

        frequenciesByBirdType.Add(1, 0);
        frequenciesByBirdType.Add(2, 0);
        frequenciesByBirdType.Add(3, 0);
        frequenciesByBirdType.Add(4, 0);
        frequenciesByBirdType.Add(5, 0);

        for (int i = 0; i < arr.Count; ++i)
            frequenciesByBirdType[arr[i]]++;

        return findMinimumBirdTypeWithMaximumFrequency(frequenciesByBirdType);

    }

    static void Main(string[] args)
    {
        int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        int result = migratoryBirds(arr);

        //To run on Visual Studio
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
