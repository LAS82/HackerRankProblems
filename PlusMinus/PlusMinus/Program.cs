using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlusMinus
{
    class Program
    {
        // Complete the plusMinus function below.
        static void plusMinus(int[] arr)
        {

            double negative = 0;
            double positive = 0;
            double zeros = 0;

            for (int i = 0; i < arr.Length; ++i)
                _ = arr[i] > 0 ? positive++ : arr[i] < 0 ? negative++ : zeros++;

            Console.WriteLine(Math.Round(positive / arr.Length, 6));
            Console.WriteLine(Math.Round(negative / arr.Length, 6));
            Console.WriteLine(Math.Round(zeros / arr.Length, 6));

            Console.ReadKey();

        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            plusMinus(arr);
        }
    }
}
