using System;
using System.Collections.Generic;
using System.Linq;

namespace Hackrank_DictionariesandMaps
{
    class Program
    {
        static void Main(string[] args)
        {
           Dictionary<string,int> phoneBooks=new Dictionary<string, int>();
           int n=int.Parse(Console.ReadLine());
           string list = string.Empty;
           for (int i = 0; i < n; i++)
           {
               list=Console.ReadLine();
               phoneBooks.Add(list.Substring(0,list.IndexOf(' ')),int.Parse(list.Substring(list.IndexOf(' '),(list.Length-list.IndexOf(' ')))));
               list=string.Empty;
           }

           
           string query=string.Empty;
            while((query=Console.ReadLine())!=null)
           {
               if(phoneBooks.ContainsKey(query))
               Console.WriteLine(query+"="+phoneBooks[query]);
               else
               Console.WriteLine("Not found");
           }
           
        }
    }
}

