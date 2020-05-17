using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{

    /*
     * Complete the pageCount function below.
     */
    static int pageCount(int n, int p)
    {
        //first page
        if (p == 1)
            return 0;

        //last or last even page
        if (p == n || (p % 2) == 0 && p == n - 1)
            return 0;

        //When the last page is the even page and the search page is the last - 1
        if ((n % 2) == 0 && p == n - 1)
            return 1;

        int fromBeginning = (p / 2);
        int fromEnd = ((n - p) / 2);

        return fromBeginning < fromEnd ? fromBeginning : fromEnd;
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int p = Convert.ToInt32(Console.ReadLine());

        int result = pageCount(n, p);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
