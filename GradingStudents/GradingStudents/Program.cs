using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingStudents
{

    class Result
    {

        /*
         * Complete the 'gradingStudents' function below.
         *
         * The function is expected to return an INTEGER_ARRAY.
         * The function accepts INTEGER_ARRAY grades as parameter.
         */

        public static List<int> gradingStudents(List<int> grades)
        {
            List<int> finalGrades = new List<int>(grades.Count);

            foreach (int grade in grades)
            {
                int intGrade = grade;
                int moduleFive = grade % 5;
                double roundedGrade = Math.Round((double)grade / 5) * 5;

                if (roundedGrade < 40)
                {
                    finalGrades.Add(intGrade);
                    continue;
                }

                if (roundedGrade > intGrade && roundedGrade - intGrade < 3)
                    intGrade = (int)roundedGrade;

                finalGrades.Add(intGrade);
            }

            return finalGrades;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int gradesCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> grades = new List<int>();

            for (int i = 0; i < gradesCount; i++)
            {
                int gradesItem = Convert.ToInt32(Console.ReadLine().Trim());
                grades.Add(gradesItem);
            }

            List<int> result = Result.gradingStudents(grades);

            Console.WriteLine(String.Join("\n", result));

            //textWriter.WriteLine(String.Join("\n", result));

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
