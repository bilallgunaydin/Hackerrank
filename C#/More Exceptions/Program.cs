using System;

namespace Hackrank_MoreExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
          Calculator myCalculator=new  Calculator();
        int T=Int32.Parse(Console.ReadLine());
        while(T-->0)
        {
            string[] num = Console.ReadLine().Split();
            int n = int.Parse(num[0]);
            int p = int.Parse(num[1]); 
            try
            {
               
                int ans=myCalculator.power(n,p);
                Console.WriteLine(ans);
                
            }
            catch(FormatException e)
            {
               Console.WriteLine(e.Message);

            }
        }
    }
    
    }
    class Calculator
    {
        public int power(int n, int p)
        {  if(n>=0 && p>=0)
          {
          int result=1;
          for (int i = 0; i < p; i++)
          {
              result=result*n;
          }
             return result;
          }

          else
          {
            throw new ArgumentException(string.Format("n and p should be non-negative"));
          }
                 
        }

      
        
    }
}

   
    

