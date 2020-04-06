using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViralAdvertising
{
    class Program
    {
        // Complete the viralAdvertising function below.
        static int viralAdvertising(int n)
        {

            int liked = 2;
            int cumulativeLikes = 2;

            for (int i = 2; i <= n; ++i)
            {
                liked = (liked * 3) / 2;
                cumulativeLikes += liked;
            }

            return cumulativeLikes;

        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int result = viralAdvertising(n);

            //To run on Visual Studio
            Console.WriteLine(result);
            Console.ReadKey();

            /*
            To run on hackerrank
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
            */
        }
    }
}
