using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeConversion
{
    class Program
    {
        /*
        * Complete the timeConversion function below.
        */
        static string timeConversion(string s)
        {
            /*
             * Write your code here.
             */

            return String.Empty;
        }

        static void Main(string[] args)
        {

            string s = Console.ReadLine();

            string result = timeConversion(s);


            //To run on Visual Studio
            Console.WriteLine(result);

            /*
            //To run on HackerRank
            TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
            tw.WriteLine(result);

            tw.Flush();
            tw.Close();
            */

        }
    }
}
