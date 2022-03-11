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

namespace hackrank_Birthday_Cake_Candles
{
    class Program
    {
        static void Main(string[] args)
        {
            

        int candlesCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> candles = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(candlesTemp => Convert.ToInt32(candlesTemp)).ToList();

        int result = Result.birthdayCakeCandles(candles);

        Console.WriteLine(result);

        
        }
    }
    class Result
{
     public static int birthdayCakeCandles(List<int> candles)
    {
        int candlesCount=0; int first=0;
        int[]dizi=new int[candles.Count];
        for (int i = 0; i < candles.Count; i++)
        {
            dizi[i]=candles[i];
        }

        Array.Sort(dizi);
        Array.Reverse(dizi);
        first=dizi[0];
        for (int i = 0; i < dizi.Length; i++)
        {
            if(first==dizi[i])
                candlesCount++;
        }

        return candlesCount;
    }
}
}
