using System;

namespace hackrank_Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

           int result = Result.factorial(n);
           Console.WriteLine(result);
        }
    }

    class Result
    {
        public static int factorial(int n)
        {   
            if(n<=1)
            return 1;

                return n*factorial(n-1);

        }
    }
}
