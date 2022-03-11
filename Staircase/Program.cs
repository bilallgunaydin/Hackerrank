using System;

namespace hackrankfor
{
    class Program
    {
        static void Main(string[] args)
        {
            
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        Result.staircase(n);


        }
    }
    class Result
{

    /*
     * Complete the 'staircase' function below.
     *
     * The function accepts INTEGER n as parameter.
     */

    public static void staircase(int n)
    {
            
            if(0<n && n<=100)
            {
            int i, j, k;
                for (i = 1; i <= n; i++)
                    {
                    for (j = 1; j <= n - i; j++)
                        {
                            Console.Write(" ");
                        }
                    for (k = 1; k <= i; k++)
                        {
                            Console.Write("#");
                        }
                      Console.WriteLine("");
                    }
                Console.ReadLine();
            }
    }

}   
}
