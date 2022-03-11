using System;

namespace hackrank_if
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sayı girin: ");
            int N = Convert.ToInt32(Console.ReadLine().Trim());
        
            if(N>=1 && N<=100)
            {
                if(N%2==1){
                    Console.WriteLine("Weird");
                }
                else if(N>=2 && N<=5 && N%2==0){
                    Console.WriteLine("Not Weird"); 
                }

                else if(N>=6 && N<=20 && N%2==0){
                    Console.WriteLine("Weird"); 
                }
                else if(N>=20 && N%2==0){
                    Console.WriteLine("Not Weird");
                }
            }
            
            // }
            // string v;
            // if(['abc','def','ghj']).includes(v))
            // {
            //     Console.WriteLine("bitti");
            // }
            // else
            // {
            //     Console.WriteLine("Bitmedi");
            // }
    }
}
