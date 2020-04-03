using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingValleys
{
    class Program
    {
        // Complete the countingValleys function below.
        static int countingValleys(int n, string s)
        {

            int valleysTraversed = 0;
            int level = 0;  //0 is the sea level

            for (int i = 0; i < s.Length; ++i)
            {
                if (s[i] == 68)
                {
                    if (level == 0)
                        ++valleysTraversed;

                    --level;
                }
                else if (s[i] == 85)
                    ++level;
            }

            return valleysTraversed;

        }

        static void Main(string[] args)
        {

            int n = Convert.ToInt32(Console.ReadLine());

            string s = Console.ReadLine();

            int result = countingValleys(n, s);

            Console.WriteLine(result);
            Console.ReadKey();

            /*
            //To run on hackerRank
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
            */
        }
    }
}
