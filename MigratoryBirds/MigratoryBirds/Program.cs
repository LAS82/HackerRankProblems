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

    public static int findMaximumFrequency(Dictionary<int, int> frequenciesByBirdType)
    {
        int maxFrequency = 0;

        foreach (KeyValuePair<int, int> freq in frequenciesByBirdType)
            if (freq.Value > maxFrequency)
                maxFrequency = freq.Value;

        return maxFrequency;
    }

    public static int findMinimumBirdTypeWithMaximumFrequency(Dictionary<int, int> frequenciesByBirdType, int maximumFrequency)
    {
        int birdTypeToRet = int.MaxValue;

        foreach (KeyValuePair<int, int> freq in frequenciesByBirdType)
            if (freq.Value == maximumFrequency && freq.Key < birdTypeToRet)
                birdTypeToRet = freq.Key;

        return birdTypeToRet;
    }

    // Complete the migratoryBirds function below.
    static int migratoryBirds(List<int> arr)
    {

        Dictionary<int, int> frequenciesByBirdType =
            new Dictionary<int, int>();

        int maxFrequency;

        for (int i = 0; i < arr.Count; ++i)
        {
            if (frequenciesByBirdType.ContainsKey(arr[i]))
                frequenciesByBirdType[arr[i]]++;
            else
                frequenciesByBirdType.Add(arr[i], 1);
        }

        maxFrequency = findMaximumFrequency(frequenciesByBirdType);

        return findMinimumBirdTypeWithMaximumFrequency(frequenciesByBirdType, maxFrequency);

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
