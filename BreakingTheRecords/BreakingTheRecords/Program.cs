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
            int highest = scores[0];
            int lowest = scores[0];
            int numOfHighest = 0;
            int numOfLowest = 0;

            for (int i = 1; i < scores.Length; ++i)
            {
                if (scores[i] > highest)
                {
                    numOfHighest++;
                    highest = scores[i];
                }
                else if (scores[i] < lowest)
                {
                    numOfLowest++;
                    lowest = scores[i];
                }
            }

            return new int[2] { numOfHighest, numOfLowest };
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
