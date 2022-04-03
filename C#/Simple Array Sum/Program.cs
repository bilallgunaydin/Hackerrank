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

namespace hackrank_SimpleArraySum
{
    class Program
    {
        static void Main(string[] args)
        {
           int arCount = Convert.ToInt32(Console.ReadLine().Trim());
            List<int> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();
            int total=0;
            foreach (var item in ar)
            {
                total=total+item;
            }
            
            Console.WriteLine(total);
        }
    }
}
