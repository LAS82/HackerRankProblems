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

            string[] sSplitted = s.Split(':');

            string amOrPm = sSplitted[sSplitted.Length - 1].Substring(2);

            sSplitted[sSplitted.Length - 1] = sSplitted[sSplitted.Length - 1].Remove(2);

            if (amOrPm == "PM" && sSplitted[0] != "12")
                sSplitted[0] = (Convert.ToInt32(sSplitted[0]) + 12).ToString();
            if (amOrPm == "AM" && sSplitted[0] == "12")
                sSplitted[0] = "00";

            return String.Join(":", sSplitted);
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
