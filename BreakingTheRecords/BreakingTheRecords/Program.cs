using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakingTheRecords
{
    class Program
    {

        // Complete the breakingRecords function below.
        static int[] breakingRecords(int[] scores)
        {
            return null;
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] scores = Array.ConvertAll(Console.ReadLine().Split(' '), scoresTemp => Convert.ToInt32(scoresTemp));

            int[] result = breakingRecords(scores);

            //To tun on Visual Studio
            Console.WriteLine(string.Join(" ", result));

            /*
            // To run on HackerRank
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
            textWriter.WriteLine(string.Join(" ", result));

            textWriter.Flush();
            textWriter.Close();
            */
        }
    }
}
