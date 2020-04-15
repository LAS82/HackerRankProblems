using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LonelyInteger
{

    class Program
    {

        // Complete the lonelyinteger function below.
        static int lonelyinteger(int[] a)
        {
            return -1;
        }

        static void Main(string[] args)
        {
            

            int n = Convert.ToInt32(Console.ReadLine());

            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp));
            int result = lonelyinteger(a);

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
