using System;
using System.Linq;

namespace Scope
{
    class Program
    {
        static void Main(string[] args)
        {
            Convert.ToInt32(Console.ReadLine());
        
            int[] a = Console.ReadLine().Split(' ').Select(x=>Convert.ToInt32(x)).ToArray();
            
            Difference d = new Difference(a);
            
            d.computeDifference();
            
            Console.Write(d.maximumDifference);
        }
    }
    class Difference {
    public Difference(int [] comeArray)
    {
        elements=comeArray;
    }
    private int[] elements;
    public int maximumDifference;

    public int computeDifference()
    {
        Array.Sort(elements);
        maximumDifference= Math.Abs(elements.Min()-elements.Max());
        return maximumDifference;
    }

	// Add your code here

} 

}
