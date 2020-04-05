using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cat_and_Mouse
{
    class Program
    {
        // Complete the catAndMouse function below.
        static string catAndMouse(int x, int y, int z)
        {

            int distanceToCatA = Math.Abs(z - x);
            int distanceToCatB = Math.Abs(z - y);

            if (distanceToCatA < distanceToCatB)
                return "Cat A";
            else if (distanceToCatA > distanceToCatB)
                return "Cat B";
            else
                return "Mouse C";

        }

        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int q = Convert.ToInt32(Console.ReadLine());

            for (int qItr = 0; qItr < q; qItr++)
            {
                string[] xyz = Console.ReadLine().Split(' ');

                int x = Convert.ToInt32(xyz[0]);

                int y = Convert.ToInt32(xyz[1]);

                int z = Convert.ToInt32(xyz[2]);

                string result = catAndMouse(x, y, z);

                //textWriter.WriteLine(result);
                Console.WriteLine(result);
            }

            //textWriter.Flush();
            //textWriter.Close();
            Console.ReadKey();
        }
    }
}
