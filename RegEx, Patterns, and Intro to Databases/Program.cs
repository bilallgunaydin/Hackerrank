using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace RegEx__Patterns__and_Intro_to_Databases
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine().Trim());
            List<string> nameList = new List<string>();
            Regex filter = new Regex(@"@gmail.com");
            for (int NItr = 0; NItr < N; NItr++)
            {
                string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

                string firstName = firstMultipleInput[0];

                string emailID = firstMultipleInput[1];
                // if(emailID.Contains("@gmail.com"))
                var match=filter.Match(emailID);
                if(match.Success)
                nameList.Add(firstName);
            }

            nameList.Sort();
            foreach(string s in nameList)
            {
                Console.WriteLine(s);
            }
            
        }
    }
}
