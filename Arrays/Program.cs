using System.Collections.Generic;
using System.Linq;
using System;

namespace Hackrank_Arrays_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
            int[] dizi=new int[arr.Count];
            for (int i = 0; i < arr.Count; i++)
            {
                dizi[i]=arr[i];
            }

            Array.Reverse(dizi);
            foreach (var item in dizi)
            {
                Console.Write(+item+" ");
            }
        }
    }
}
