using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunnyString
{
    class Program
    {
        static string funnyString(string s)
        {
            int sCalc, rCalc;

            for (int index = 0; index < s.Length - 1; ++index)
            {
                int reverseIndex = s.Length - index - 1;

                sCalc = Math.Abs(s[index] - s[index + 1]);
                rCalc = Math.Abs(s[reverseIndex] - s[reverseIndex - 1]);

                if (sCalc != rCalc)
                    return "Not Funny";
            }

            return "Funny";

        }

        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int q = Convert.ToInt32(Console.ReadLine());

            for (int qItr = 0; qItr < q; qItr++)
            {
                string s = Console.ReadLine();

                string result = funnyString(s);

                //textWriter.WriteLine(result);
                Console.WriteLine(result);
            }
            Console.ReadKey();
            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
