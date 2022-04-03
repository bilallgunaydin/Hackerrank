using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace hackrank_migratoryBirds
{
    class Program
    {
        static void Main(string[] args)
        {
            int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            int result = Result.migratoryBirds(arr);
            Console.WriteLine(result);
            // int[] dizi = new int[] { 1, 2, 2, 3, 3, 3, 5, 5, 8, 8, 8, 8, 9, 9, 9, 9, 9, 10};
            // int sayi = 0;
            // int tekrarSayisi = 0;
            // int geciciTekrar = 1;

            // for (int i = 0; i < dizi.Length-1; i++)
            // {
            //     if (dizi[i] == dizi[i + 1])
            //         geciciTekrar++;
                
            //     if( i==(dizi.Length-2) || dizi[i] != dizi[i+1])
            //     {
            //         if (geciciTekrar > tekrarSayisi)
            //         {
            //             tekrarSayisi = geciciTekrar;
            //             sayi = dizi[i];
            //         }
                   
            //         geciciTekrar = 1;
            //     }
            // }

            
            
            // Console.WriteLine(sayi + " sayisi en çok tekrarlanmıştır. Ve bu sayı " + tekrarSayisi + "  kez tekrar edilmiştir." );
            // Console.ReadLine();

        }
    }
    class Result
    {
        public static int migratoryBirds(List<int> arr)
        {
        //     int max = 0;
        //     int type = 0;
        //     int[] freq = new int[5];
        //     for(int i = 0; i < 6; i++)
        //     {
        //         freq[arr[i]-1]++;
        //     }
            
        //     for(int i = 0; i < 5; i++)
        //     {
        //         if(freq[i] > max)
        //         {
        //             max = freq[i];
        //             type = i+1;
        //         }
        //     }
        // return type;
         int[] birdCounts = new int[6];

        foreach (var type in arr)
            birdCounts[type]++;

        int maxValue = birdCounts.Max();
        int maxType = birdCounts.ToList().IndexOf(maxValue);
        return maxType;

        
        
                // int count=0;
                // for (int i = 0; i < arr.Count; i++)
                // {
                //     for (int j = 0; j < arr.Count; j++)
                //     {
                //         if(arr[i]==arr[j])
                //         count++;
                //     }
                // }
                
                // return 0;
        }
    }

}
