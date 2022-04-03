using System;

namespace Binary_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
        int count = 0;
        int max = 0;
        int n = Convert.ToInt32(Console.ReadLine());
        while(n>0)
        {
            int kalan=n%2;
            n=n/2;
            if(kalan==1)
            count++;
            else
            count=0;
            if(max<count)
            max=count;

        }
        Console.WriteLine(max);
        }
    }
}
