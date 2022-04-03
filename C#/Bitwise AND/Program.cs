using System;

namespace Bitwise_AND
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine().Trim());

            for (int tItr = 0; tItr < t; tItr++)
            {
                string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

                int count = Convert.ToInt32(firstMultipleInput[0]);

                int lim = Convert.ToInt32(firstMultipleInput[1]);

                int res =bitwiseAnd(count, lim);

                Console.WriteLine(res);
            }


        }

        public static int bitwiseAnd(int N, int K)
        {
            // Creates the array
            int[] numArray = new int[N];
            for(int i=0; i < N; i++)
                numArray[i] = i+1;
        
            int length = numArray.Length;
            
            int final_answer = 0;
            for(int a = 0; a < length; a++)
            {
                for(int b = a+1; b < length; b++)
                {
                    int curent_answer = numArray[a] & numArray[b];

                    if(curent_answer < K && curent_answer > final_answer)
                        final_answer = curent_answer;
                }
            }
            return final_answer;
        }
    }
}
