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


namespace hackrank_Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int max = 0;
            int n = Convert.ToInt32(Console.ReadLine());

            while (n > 0)
            {
                int reminder = n % 2;
                n = n / 2;
                if (reminder == 1)
                {
                    count++;
                }
               else
                {
                    count = 0;
                }
                if (max < count)
                {
                    max = count;
                }
            }
            Console.WriteLine(max);
            Console.ReadKey();


        }
        
    }
    

}

