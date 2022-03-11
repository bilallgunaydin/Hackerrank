using System;

namespace Running_Time_and_Complexity
{
    class Program
    {
        static void Main(string[] args)
        {
              int n=int.Parse(Console.ReadLine());
              for(int i = 0; i < n; i++)
                {
                    int x = int.Parse(Console.ReadLine());
                    CheckPrime(x);
                }   
        }
        public static void CheckPrime(int n) 
        {
            bool isPrime = n > 1;
            for(int i = 2; i <= Math.Sqrt(n); i++) {
                if (n % i == 0) {
                    isPrime = false;
                    break;
                }
            }
            
            Console.WriteLine(isPrime ? "Prime" : "Not prime");
        }
    }
}
