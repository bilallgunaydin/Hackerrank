using System;
using System.Text;

namespace Repeated_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            long n = Convert.ToInt64(Console.ReadLine().Trim());

            long result = Result.repeatedString(s, n);

            Console.WriteLine(result);
        }
    }

    class Result
    {

    /*
     * Complete the 'repeatedString' function below.
     *
     * The function is expected to return a LONG_INTEGER.
     * The function accepts following parameters:
     *  1. STRING s
     *  2. LONG_INTEGER n
     */

    public static long repeatedString(string s, long n)
    {
        long a=0;

        foreach (char ch in s)
        {
            if(ch=='a')
            a++;
        }

        a*=(n/s.Length);
        long rem=n%s.Length;
        for (int i = 0; i < rem; i++)
        {
            if(s[i]=='a')
            a++;
        }
        return a;
    }

    }
}
