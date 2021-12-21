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


namespace hackrank_compareTheTriplets
{
    class Program
    {
        static void Main(string[] args)
        {
        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

        List<int> result = Result.compareTriplets(a, b);

        foreach (var item in result)
        {
            Console.Write(item+" ");
        }

        }
    }
    class Result
{
      public static List<int> compareTriplets(List<int> a, List<int> b)
    {   
            int alice=0; int bob=0;
            if(a.Count==b.Count){
                for (int i = 0; i < a.Count; i++)
                {
                    if(1<=a[i] && a[i]<=100 && 1<=b[i] && b[i]<=100)
                    if(a[i]>b[i])
                        alice++;
                     else if(a[i]<b[i])
                        bob++;
                    else if(a[i]==b[i])
                        alice=alice+0;
                        bob=bob+0;
                }
            }
            List<int> newResult=new List<int>();
            newResult.Add(alice);
            newResult.Add(bob);
            return newResult;
    }
}
}
