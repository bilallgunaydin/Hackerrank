using System;
using System.Collections.Generic;
using System.Collections;
namespace hackrankdizichallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            
        int n = Convert.ToInt32(Console.ReadLine());
        string inputs = Console.ReadLine();
        string[] arr = inputs.Split(' ');

        Result.plusMinus(arr, n);

        }
    }
    class Result
    {
         public static void plusMinus(string[] arr, int n)
    {
        int neg=0; 
        int pos=0;
        int zero=0;
            if( 0<n && n<=100)
            {
               for (int i = 0; i < n; i++)
               {
                   int newnumber=Convert.ToInt32(arr[i]);
                   if(-100<=newnumber && newnumber<=100)
                   {
                       if(newnumber<0)
                            neg=neg+1;
                        else if(newnumber>0)
                            pos=pos+1;
                            else
                            zero=zero+1;
                   }
               }
            }
            Decimal posResult=Convert.ToDecimal(pos)/Convert.ToDecimal(n);
            Console.WriteLine("Positive result: "+posResult.ToString("0.000000"));
            Decimal negResult=Convert.ToDecimal(neg)/Convert.ToDecimal(n);
            Console.WriteLine("Negative result: "+negResult.ToString("0.000000"));
            Decimal zeroResult=Convert.ToDecimal(zero)/Convert.ToDecimal(n);
            Console.WriteLine("Zero result: "+zeroResult.ToString("0.000000"));

    }
    
    }
}
