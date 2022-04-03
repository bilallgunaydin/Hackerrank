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

namespace Hackrank_Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
           int n = Convert.ToInt32(Console.ReadLine().Trim());
           List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();
            int transport=0;
            int numberOfSwaps = 0;
            
            for (int i = 0; i < a.Count; i++)
            {
                for (int j = i; j < a.Count; j++)
                {
                    if (a[i]>a[j])
                    {
                        transport=a[j];
                        a[j] = a[i];
                        a[i] = transport;
                        numberOfSwaps++;
                    }
                }
            }
            Console.WriteLine("Array is sorted in "+numberOfSwaps+" swaps");
            Console.WriteLine("First Element:"+a[0]);
            Console.WriteLine("Last Element: "+a[a.Count-1]);

          
    }
    }
    }
        