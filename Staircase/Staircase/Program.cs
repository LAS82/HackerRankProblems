using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staircase
{
    class Program
    {
        // Complete the staircase function below.
        static void staircase(int n)
        {

            StringBuilder stair = new StringBuilder((n * n) + n);
            int blankSpaceSize;
            int stairStepSize;
            for (int i = 0; i < n; ++i)
            {
                blankSpaceSize = n - i - 1;
                stairStepSize = i + 1;

                stair.Append(new String(' ', blankSpaceSize))
                    .AppendLine(new String('#', stairStepSize));
            }

            Console.WriteLine(stair);

        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            staircase(n);
        }
    }
}
