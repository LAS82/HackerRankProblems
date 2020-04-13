using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayCakeCandles
{
    class Program
    {
        // Complete the birthdayCakeCandles function below.
        static int birthdayCakeCandles(int[] ar)
        {
            int max = maxInt(ar);
            int numOfMax = 0;

            for (int i = 0; i < ar.Length; ++i)
                if (ar[i] == max)
                    ++numOfMax;

            return numOfMax;

        }

        static int maxInt(int[] ar)
        {
            int res = 0;

            for (int i = 0; i < ar.Length; ++i)
                if (ar[i] > res)
                    res = ar[i];

            return res;
        }

        static void Main(string[] args)
        {
            

            int arCount = Convert.ToInt32(Console.ReadLine());

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));
            int result = birthdayCakeCandles(ar);

            //To run on Visual Studio
            Console.WriteLine(result);

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
