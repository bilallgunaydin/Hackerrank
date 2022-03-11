using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            AdvancedArithmetic myCalculator = new Calculator();
            int sum = myCalculator.divisorSum(n);
            Console.WriteLine("I implemented: AdvancedArithmetic\n" + sum); 
        }
    }

    public interface AdvancedArithmetic
    {
        int divisorSum(int n);
    }

    public class Calculator : AdvancedArithmetic
    {
        public int divisorSum(int n)
        {
            int result;
            int sum=0;
            for (int i =1; i <= n; i++)
            {
                result=n%i;
                if(result==0)
                sum=sum+i;
            }
            return sum;
        }
    }
}
