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

    // Complete the designerPdfViewer function below.
    static int designerPdfViewer(int[] h, string word)
    {

        int tallestSize = 0;

        for (int i = 0; i < word.Length; ++i)
        {
            int currentLetterSize = h[word[i] - 97];

            if (currentLetterSize > tallestSize)
                tallestSize = currentLetterSize;
        }

        return tallestSize * word.Length;

    }

    static void Main(string[] args)
    {
        int[] h = Array.ConvertAll(Console.ReadLine().Split(' '), hTemp => Convert.ToInt32(hTemp));
        string word = Console.ReadLine();

        int result = designerPdfViewer(h, word);

        /*
        // To run on HackerRank
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
        */

        Console.WriteLine(result);
        Console.ReadKey();
    }
}
