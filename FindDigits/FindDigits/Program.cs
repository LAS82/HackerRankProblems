using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindDigits
{
    class Program
    {
        // Complete the findDigits function below.
        static int findDigits(int n)
        {
            int divisorToFindDigit = 1;
            int digit;
            int numOfDivisors = 0;

            while (divisorToFindDigit < n)
            {
                digit = (n / divisorToFindDigit) % 10; //Based on a formula given at discussions page
                divisorToFindDigit *= 10;

                if (digit == 0)
                    continue;

                if (n % digit == 0)
                    numOfDivisors++;
            }

            return numOfDivisors;

        }

        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                int n = Convert.ToInt32(Console.ReadLine());

                int result = findDigits(n);

                //textWriter.WriteLine(result);

                Console.WriteLine(result);
            }

            //textWriter.Flush();
            //textWriter.Close();

            Console.ReadKey();
        }

    }
}
