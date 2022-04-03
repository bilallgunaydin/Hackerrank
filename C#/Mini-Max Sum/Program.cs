using System;
using System.Collections.Generic;
using System.Linq;

namespace Mini_Max_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            Result.miniMaxSum(arr);
        }
    }

    class Result
{

    /*
     * Complete the 'miniMaxSum' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void miniMaxSum(List<int> arr)
    {
        arr.Sort();
        long max=0, min=0;
        for(int i=0;i<arr.Count-1;i++)
        {
            min += arr[i];
        }
        arr.Reverse();
        for(int i=0;i<arr.Count-1;i++)
        {
            max += arr[i];
        }
        Console.WriteLine(min+" "+max);
        
    }

}
}
