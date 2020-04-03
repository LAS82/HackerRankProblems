using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SockMerchant
{
    class Program
    {

        static Dictionary<int, int> organizeSocksByColor(int[] ar)
        {
            Dictionary<int, int> socksByColor = new Dictionary<int, int>(ar.Count() / 2);

            for (int i = 0; i < ar.Length; ++i)
            {
                if (socksByColor.ContainsKey(ar[i]))
                {
                    socksByColor[ar[i]]++;
                    continue;
                }

                socksByColor.Add(ar[i], 1);
            }

            return socksByColor;
        }

        // Complete the sockMerchant function below.
        static int sockMerchant(int n, int[] ar)
        {
            Dictionary<int, int> socksByColor = organizeSocksByColor(ar);
            int numOfPairs = 0;

            foreach (KeyValuePair<int, int> socks in socksByColor)
                numOfPairs += socks.Value / 2;

            return numOfPairs;
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));

            int result = sockMerchant(n, ar);


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
