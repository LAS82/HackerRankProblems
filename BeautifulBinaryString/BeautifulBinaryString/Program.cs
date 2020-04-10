using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautifulBinaryString
{
    class Program
    {
        // Complete the beautifulBinaryString function below.
        static int beautifulBinaryString(string b)
        {

            int originalSize = b.Length;
            int beautifulSize = b.Replace("010", String.Empty).Length;

            return (originalSize - beautifulSize) / 3;

        }

        static void Main(string[] args)
        {


            int n = Convert.ToInt32(Console.ReadLine());

            string b = Console.ReadLine();

            int result = beautifulBinaryString(b);

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
