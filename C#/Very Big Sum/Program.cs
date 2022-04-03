using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Hackrank_verybigsum
{
    class Program
    {
        static void Main(string[] args)
        {
            int arCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<long> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt64(arTemp)).ToList();

        long result = Result.aVeryBigSum(ar);
        Console.WriteLine(result);
        }
    }
    class Result
    {
    public static long aVeryBigSum(List<long> ar)
    {
        long total=0;
        foreach (var item in ar)
        {
            total=total+item;
        }
            return total;
    }
    }
}
