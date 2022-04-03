using System;
using System.Collections.Generic;

namespace Grading_Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int gradesCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> grades = new List<int>();

            for (int i = 0; i < gradesCount; i++)
            {
                int gradesItem = Convert.ToInt32(Console.ReadLine().Trim());
                grades.Add(gradesItem);
            }

            List<int> result = Result.gradingStudents(grades);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }

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
           for (int i = 0; i < grades.Count; i++)
           {
               if(grades[i]<38)
               {
                   continue;
               }
               else if((grades[i]+2)%5==0)
               {
                   grades[i] = grades[i] + 2;
               }
               else if((grades[i]+1)%5==0)
               {
                   grades[i] = grades[i] + 1;
               }
           }
            return grades;
        }

    }

}
