﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeatedString
{
    class Program
    {
        // Complete the repeatedString function below.
        static long repeatedString(string s, long n)
        {

            return 0;
        }

        static void Main(string[] args)
        {
            

            string s = Console.ReadLine();

            long n = Convert.ToInt64(Console.ReadLine());

            long result = repeatedString(s, n);

            //To run on Visual Studio
            Console.WriteLine(result);
            Console.ReadKey();

            /*
            //To run on HackerRank
             
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
            */
        }
    }
}
