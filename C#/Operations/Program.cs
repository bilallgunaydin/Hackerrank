using System;

namespace hackrank
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Ana para:");
        double meal_cost = Convert.ToDouble(Console.ReadLine().Trim());
        Console.WriteLine("Bahşiş:");
        int tip_percent = Convert.ToInt32(Console.ReadLine().Trim());
        Console.WriteLine("Kdv:");
        int tax_percent = Convert.ToInt32(Console.ReadLine().Trim());

        double resultt = Result.solve(meal_cost, tip_percent, tax_percent);
        Console.WriteLine(resultt);
        }
    }
    
    class Result{
         public static double solve(double meal_cost, int tip_percent, int tax_percent)
    {
            double tip=(double)(meal_cost*tip_percent)/100;
            double tax=(double)(tax_percent*meal_cost)/100;
            double total =Math.Round(meal_cost + tax + tip);
            return total;
           
    }
    }
}
