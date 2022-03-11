using System;

namespace Nested_Logic
{
    class Program
    {
        static void Main(string[] args)
        {
            int fine=0;
            var returnedDate = Console.ReadLine().Split(' ');
            var day1 = int.Parse(returnedDate[0]);
            var month1 = int.Parse(returnedDate[1]);
            var year1 = int.Parse(returnedDate[2]);

            var dueDate = Console.ReadLine().Split(' ');
            var day2 = int.Parse(dueDate[0]);
            var month2 = int.Parse(dueDate[1]);
            var year2 = int.Parse(dueDate[2]);
            
                if (year1 > year2)
                fine=10000;
                else if(year1==year2)
                if(month1==month2 && day1>day2)
                {
                    fine=15*(day1-day2);
                    
                }
                else if(month1>month2 && year1==year2)
                {
                    fine=500*(month1-month2);
                }
                
                Console.WriteLine(fine);
                
        }
    }
}
