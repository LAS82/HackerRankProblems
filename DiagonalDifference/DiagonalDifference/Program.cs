using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagonalDifference
{
    class Result
    {

        /*
         * Complete the 'diagonalDifference' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts 2D_INTEGER_ARRAY arr as parameter.
         */

        public static int diagonalDifference(List<List<int>> arr)
        {
            int leftToRightSum = 0;
            int rightToLeftSum = 0;

            for (int i = 0; i < arr.Count; ++i)
            {
                leftToRightSum += arr[i][i];
                rightToLeftSum += arr[i][arr.Count - i - 1];
            }

            return Math.Abs(leftToRightSum - rightToLeftSum);
        }

    }

    class Program
    {
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<List<int>> arr = new List<List<int>>();

            for (int i = 0; i < n; i++)
            {
                arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            }

            int result = Result.diagonalDifference(arr);

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
