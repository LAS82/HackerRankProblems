using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareTheTriplets
{
    class Program
    {
        // Complete the compareTriplets function below.
        static List<int> compareTriplets(List<int> a, List<int> b)
        {

            List<int> points = new List<int>(new int[] { 0, 0 });
            const int aliceScoreIndex = 0;
            const int bobScoreIndex = 1;

            for (int i = 0; i < a.Count(); ++i)
            {
                if (a[i] > b[i])
                    points[aliceScoreIndex]++;
                else if (a[i] < b[i])
                    points[bobScoreIndex]++;
            }

            return points;
        }

        static void Main(string[] args)
        {
            

            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

            List<int> result = compareTriplets(a, b);

            //To run on Visual Studio
            Console.WriteLine($"Alice's score is: {result[0]}");
            Console.WriteLine($"Bob's score is: {result[1]}");
            Console.ReadKey();


            /*
            //To run on HackerRank
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
            textWriter.WriteLine(String.Join(" ", result));

            textWriter.Flush();
            textWriter.Close();
            */
        }
    }
}
