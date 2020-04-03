using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniMaxSum
{
    class Program
    {

        // Complete the miniMaxSum function below.
        static void miniMaxSum(int[] arr)
        {
            long sum = 0;
            long min = 0;
            long max = 0;
            long tempSum;

            for (int i = 0; i < arr.Length; ++i)
                sum += arr[i];

            min = sum;

            for (int i = 0; i < arr.Length; ++i)
            {
                tempSum = sum - arr[i];

                if (tempSum < min)
                    min = tempSum;

                if (tempSum > max)
                    max = tempSum;
            }

            Console.WriteLine("{0} {1}", min, max);
        }

        static void Main(string[] args)
        {
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            miniMaxSum(arr);
        }
    }
}
