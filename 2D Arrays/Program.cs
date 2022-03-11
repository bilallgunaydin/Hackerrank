using System.Collections.Generic;
using System.Linq;
using System;

namespace _2D_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<List<int>> arr = new List<List<int>>();
            List<int> sum=new List<int>();
            int tempSum=0;

            for (int i = 0; i < 6; i++)
            {
                arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList()
                .Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            }
            for (int i=1; i<5; i++)
            {
                for (int j = 1; j<5; j++)
                {
                    tempSum=arr[i-1][j-1]   + arr[i-1][j]   + arr[i-1][j+1]
                                            + arr[i][j]     +
                            arr[i+1][j-1]   + arr[i+1][j]   + arr[i+1][j+1];
                    sum.Add(tempSum);
                    
                }
            }    
            Console.WriteLine(sum.Max());
        }
    }
}
