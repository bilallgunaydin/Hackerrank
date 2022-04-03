using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Sales_by_Match
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<int> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();

            int result = sockMerchant(n, ar);
            Console.WriteLine(result);
        }
        public static int sockMerchant(int n, List<int> ar)
        {
            
            int count=0;
            int [] dizi= new int[101];
            for (int i = 0; i < n; i++)
            {
                dizi[ar[i]]++;
            }
            for (int i = 0; i < dizi.Length; i++)
            {
                count+=dizi[i]/2;
            }
           
            return count;
        }
    }
}
    
